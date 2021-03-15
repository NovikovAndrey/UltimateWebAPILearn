using Contracts.Interfaces.Entities;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
               : base(repositoryContext)
        {

        }

        public void CreateCompany(Company company)
        {
            Create(company);
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(c => c.Name).ToList();

        }

        public Company GetCompany(Guid companyId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(companyId), trackChanges).SingleOrDefault();
        }
    }
}
