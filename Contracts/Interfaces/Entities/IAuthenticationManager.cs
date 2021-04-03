using Entities.DataTransferObjects;
using System.Threading.Tasks;

namespace Contracts.Interfaces.Entities
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
