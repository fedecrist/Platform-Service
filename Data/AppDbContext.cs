using Microsoft.EntityFrameworkCore;
using Platform_Service.Models;

namespace Platform_Service.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
