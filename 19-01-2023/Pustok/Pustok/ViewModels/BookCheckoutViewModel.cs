using Pustok.Models;

namespace Pustok.ViewModels
{
    public class BookCheckoutViewModel
    {
        public Book Book { get; set; } // 20 * 3  ==> 60
        public int Count { get; set; }
    }
}
