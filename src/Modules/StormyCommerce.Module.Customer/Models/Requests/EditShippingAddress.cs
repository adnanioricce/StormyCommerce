using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Module.Customer.Areas.Customer.Models
{
    public class EditShippingAddress
    {
        public Address Address { get; set; }
        public string WhoReceives { get; set; }
    }
}