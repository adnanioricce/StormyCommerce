using System;

namespace StormyCommerce.Core.Models.Shipment
{
    public class ShipmentCalculationForOrderModel
    {
        public ShipmentCalculationForOrderModel(){}
        private Entities.Shipment ShipmentValue; 
        public double TotalHeight { get; set; }
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double ShipmentArea { get; }        

        public void SetShipmentArea(int itemsCount)
        {
            
        }
    }
}
