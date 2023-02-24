using Microsoft.Build.Framework;

namespace Pustok.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? AppUserId { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Note { get; set; }
        public DateTime CreatedTime { get; set; }
        public double TotalPrice { get; set; }


        public AppUser AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
