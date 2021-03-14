using Entities.Models;
using System.Collections.Generic;

namespace Contracts.Interfaces.Entities
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
