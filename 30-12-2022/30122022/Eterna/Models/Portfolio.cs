using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [StringLength(maximumLength:50)]
        public string Title { get; set; }

        [StringLength(maximumLength:200)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 25)]
        public string Client { get; set; }

        public string ProjectUrl { get; set; }
        public DateTime Date { get; set; }

        public Category Category { get; set; }
        public List<PortfolioImage> PortfolioImages { get; set; }
    }
}
