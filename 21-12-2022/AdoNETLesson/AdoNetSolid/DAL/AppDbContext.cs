using AdoNetSolid.Models;
using Microsoft.EntityFrameworkCore;

namespace AdoNetSolid.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CATALYST\\SQLEXPRESS;Database=AB102FirstDB;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Country> Countries { get; set; }
    }
}
