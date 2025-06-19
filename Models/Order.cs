using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public string? CustomerName { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? PizzaType { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string? Address { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
