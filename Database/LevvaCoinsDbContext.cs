using LevvaCoinsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LevvaCoin.Database
{
    public class LevvaCoinsDbContext : DbContext 
    {
        public LevvaCoinsDbContext(DbContextOptions options) : base(connectionString) { }

        public DbSet<User> Users { get; set; }
    }
}
