using Microsoft.EntityFrameworkCore;

namespace Pustok.Models
{
    public class PustokContext : DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
    }
}
