using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength:25)]
        public string Title1 { get; set; }
        [StringLength(maximumLength:25)]
        public string Title2 { get; set; }
        [StringLength(maximumLength:250)]
        public string Desc { get; set; }
        public string RedirectUrl { get; set; }
        [StringLength(maximumLength:30)]
        public string RedirectUrlText { get; set; }
        public string Image { get; set; }
    }
}
