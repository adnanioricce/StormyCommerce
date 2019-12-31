using System;
using System.Collections.Generic;
 

namespace StormyCommerce.Core.Models.Shipment
{
    public class CalculateShippingMeasuresModel
    {
        public CalculateShippingMeasuresModel(){}
        public CalculateShippingMeasuresModel(IList<OrderItemDto> items)
        {
            Items = items;
        }
        public double TotalHeight { get; set; }
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double TotalWeight { get; set; }
        public double TotalDiameter { get; set; }
        public double CubeRoot { get; set; }
        public double TotalArea { get; set; } = 0.0;
        public IList<OrderItemDto> Items { get; set; }
        public decimal DeliveryCost { get; set; }
        public CalculateShippingMeasuresModel AdaptMeasuresForMultiplesItems()
        {
            CubeRoot = Math.Round(Math.Pow(this.TotalArea, (double)1 / 3));
            return new CalculateShippingMeasuresModel
            {
                TotalWeight = this.TotalWeight < 1 ? 1 : this.TotalWeight,
                TotalArea = CubeRoot,
                TotalHeight = this.CubeRoot < 2 ? 2 : this.CubeRoot,
                TotalWidth = this.CubeRoot < 11 ? 11 : this.CubeRoot,
                TotalLength = this.CubeRoot < 16 ? 16 : this.CubeRoot,
                TotalDiameter = Math.Sqrt(Math.Pow(TotalLength, 2) + Math.Pow(TotalWidth, 2)),
                Items = this.Items,
                CubeRoot = this.CubeRoot                
            };
        }
        public void CalculateSpaceForItemOnShippingBOx(OrderItemDto item)
        {
            this.TotalHeight += item.Product.Height;
            this.TotalWidth += item.Product.Width;
            this.TotalLength += item.Product.Length;
            this.TotalWeight += item.Product.UnitWeight * item.Quantity;
            this.TotalArea += item.Product.Height * item.Product.Width * item.Product.Length * item.Quantity;
        }

    }
}
