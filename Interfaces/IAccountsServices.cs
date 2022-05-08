using System.Threading.Tasks;
using EstateApp.Data;
using EstateApp.Models;

namespace EstateApp.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}