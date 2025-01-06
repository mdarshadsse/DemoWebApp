using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        
        public DbSet<Person> Persons { get; set; }
    }
}
