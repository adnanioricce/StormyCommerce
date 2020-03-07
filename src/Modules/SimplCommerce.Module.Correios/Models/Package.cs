using System;

namespace SimplCommerce.Module.Correios.Models
{
    public class Package
    {        
        public double TotalHeight { get; set; }
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double TotalWeight { get; set; }
        public double TotalDiameter { get; set; }
        public double CubeRoot { get; set; }
        public double TotalArea { get; set; } = 0.0;        
        public decimal DeliveryCost { get; set; }        
        public decimal Price { get; set; }        
        public static Package CreatePackage(Package package)
        {
            package.CubeRoot = Math.Round(Math.Pow(package.TotalArea, (double)1 / 3));
            return new Package
            {
                TotalWeight = package.TotalWeight < 1 ? 1 : package.TotalWeight,
                TotalArea = package.CubeRoot,
                TotalHeight = package.CubeRoot < 2 ? 2 : package.CubeRoot,
                TotalWidth = package.CubeRoot < 11 ? 11 : package.CubeRoot,
                TotalLength = package.CubeRoot < 16 ? 16 : package.CubeRoot,
                TotalDiameter = Math.Sqrt(Math.Pow(package.TotalLength, 2) + Math.Pow(package.TotalWidth, 2)),                
                CubeRoot = package.CubeRoot,
                Price = package.Price                
                
            };            
        }
    }
}