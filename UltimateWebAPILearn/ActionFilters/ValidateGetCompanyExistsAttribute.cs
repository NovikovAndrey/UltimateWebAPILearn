using Contracts.Interfaces.Entities;
using Contracts.Interfaces.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace UltimateWebAPILearn.ActionFilters
{
    public class ValidateGetCompanyExistsAttribute : IActionFilter
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ValidateGetCompanyExistsAttribute(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repository = repositoryManager;
            _logger = loggerManager;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var id = (Guid)context.ActionArguments["id"];
            var company = _repository.Company.GetCompanyAsync(id, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {id} doesn't exist in the database.");
                context.Result = new NotFoundObjectResult($"Company with id: {id} doesn't exist in the database.");
                return;
            }
        }
    }
}
