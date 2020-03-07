namespace SimplCommerce.Module.Correios.Models
{
    public class PackageItem
    {
        public PackageItem(){}        
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Diameter { get; set; }
        public double? UnitWeight { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}