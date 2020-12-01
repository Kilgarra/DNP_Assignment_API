using DNP_Assignment_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DNP_Assignment_API.DataAccess
{
    public class DBContext:DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AdultDatabase.db");
        }
    }
}