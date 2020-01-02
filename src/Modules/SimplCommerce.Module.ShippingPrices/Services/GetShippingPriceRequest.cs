using System.Collections.Generic;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Shipping.Models;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace SimplCommerce.Module.ShippingPrices.Services
{
    public class GetShippingPriceRequest
    {
        public CustomerAddress ShippingAddress { get; set; }

        public AddressDetail WarehouseAddress { get; set; }

        public IList<ShippingItem> ShippingItem { get; set; } = new List<ShippingItem>();

        public decimal OrderAmount { get; set; }
    }
}
