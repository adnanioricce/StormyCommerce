using System;

namespace StormyCommerce.Core.Models.Shipment
{
    public class ShipmentCalculationForOrderModel
    {
        public ShipmentCalculationForOrderModel(){}        
        public double TotalHeight { get; set; }
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double TotalWeight { get; set; }
        public double CubeRoot { get; set; }
        public double TotalArea { get; set; } = 0.0;    
        public ShipmentCalculationForOrderModel AdaptMeasuresForMultiplesItems()
        {
            CubeRoot = Math.Ceiling(Math.Pow(this.TotalArea, (double)1 / 3));
            return new ShipmentCalculationForOrderModel
            {
                TotalWeight = this.TotalWeight,
                TotalArea = this.TotalArea,
                TotalHeight = this.TotalHeight < 2 ? 2 : this.CubeRoot,
                TotalWidth = this.TotalWidth < 16 ? 16 : this.CubeRoot,
                TotalLength = this.TotalLength < 11 ? 11 : this.CubeRoot
            };
        }
    }
}
