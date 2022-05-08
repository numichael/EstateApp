using System.Threading.Tasks;
using estate_app.Data.Entities;
using estate_app.Models;

namespace estate_app.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}