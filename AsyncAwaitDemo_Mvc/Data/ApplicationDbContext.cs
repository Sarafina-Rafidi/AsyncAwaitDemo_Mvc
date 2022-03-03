using AsyncAwaitDemo_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncAwaitDemo_Mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
