using Microsoft.EntityFrameworkCore;
using JupiterWeb.API.Data.Models;

namespace JupiterWeb.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
    }
}