using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts.Interfaces.Entities
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(Guid companyId, bool trackChanges);
        void CreateCompany(Company company);
    }
}
