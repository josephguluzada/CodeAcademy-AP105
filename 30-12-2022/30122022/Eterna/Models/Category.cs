using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:20)]
        public string Name { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
