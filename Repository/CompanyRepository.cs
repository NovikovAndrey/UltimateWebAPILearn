using Contracts.Interfaces.Entities;
using Entities;
using Entities.Models;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
               : base(repositoryContext)
        {

        }
    }
}
