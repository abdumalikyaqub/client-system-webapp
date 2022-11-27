using Microsoft.EntityFrameworkCore;

namespace ClientSystemWebApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
