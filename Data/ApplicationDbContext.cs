using estate_app.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace estate_app.Data.DatabaseContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}