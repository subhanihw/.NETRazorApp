using Microsoft.EntityFrameworkCore;
using SampleWebApp.Model;

namespace SampleWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }   
}
