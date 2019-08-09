using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplivationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplivationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
