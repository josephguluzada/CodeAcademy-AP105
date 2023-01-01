using Microsoft.EntityFrameworkCore;

namespace Eterna.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
    }
}
