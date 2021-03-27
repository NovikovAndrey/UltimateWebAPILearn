using Contracts.Interfaces.Entities;
using Contracts.Interfaces.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace UltimateWebAPILearn.ActionFilters
{
    public class ValidateEmployeeForCompanyExistsAttributeGet : IActionFilter
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ValidateEmployeeForCompanyExistsAttributeGet(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repository = repositoryManager;
            _logger = loggerManager;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var method = context.HttpContext.Request.Method.Equals("GET");
            var companyId = (Guid)context.ActionArguments["companyId"];
            var id = (Guid)context.ActionArguments["id"];

            var company = _repository.Company.GetCompanyAsync(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
                context.Result = new NotFoundObjectResult($"Company with id: {companyId} doesn't exist in the database.");
                return;
            }
            var employeeDb = _repository.Employee.GetEmployeeAsync(companyId, id, trackChanges: false);
            if (employeeDb == null)
            {
                _logger.LogInfo($"Employee with id: {id} doesn't exist in the database.");
                context.Result = new NotFoundObjectResult($"Employee with id: {id} doesn't exist in the database.");
                return;
            }
        }
    }
}
