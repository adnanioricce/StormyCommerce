using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Module.Customer.Areas.Customer.Models
{
    public class EditShippingAddress
    {
        public AddressDetail Address { get; set; }
        public string WhoReceives { get; set; }
    }
}