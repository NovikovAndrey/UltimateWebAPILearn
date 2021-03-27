using System.Threading.Tasks;

namespace Contracts.Interfaces.Entities
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }
        Task SaveAsync();
    }
}
