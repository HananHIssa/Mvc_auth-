using Microsoft.EntityFrameworkCore;
using WebApplication12.Models;

namespace WebApplication12.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
