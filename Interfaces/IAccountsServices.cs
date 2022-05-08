using System.Threading.Tasks;
using EstateApp.Data.Entities;
using EstateApp.Models;

namespace EstateApp.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}