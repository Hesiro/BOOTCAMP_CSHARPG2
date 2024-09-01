using Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_MVC.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
