using Microsoft.AspNetCore.Identity;

namespace estate_app.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}