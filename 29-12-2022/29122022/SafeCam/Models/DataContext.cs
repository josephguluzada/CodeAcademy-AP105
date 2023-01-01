using Microsoft.EntityFrameworkCore;

namespace SafeCam.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SecurityService> SecurityServices { get; set; }
    }
}
