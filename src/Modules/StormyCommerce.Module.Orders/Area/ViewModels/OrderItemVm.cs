using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.Orders.Area.ViewModels
{
    public class OrderItemVm
    {        
        [Required]
        public double Height { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Length { get; set; }
        public double? Diameter { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }        
        [Required]
        public int QuantityPerUnity { get; set; }
        public int Quantity { get; set; }
        public long ProductId { get; set; }
    }
}
