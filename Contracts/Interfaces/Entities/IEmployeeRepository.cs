using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts.Interfaces.Entities
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
        Employee GetEmployee(Guid companyId, Guid id, bool trackChanges);

    }
}
