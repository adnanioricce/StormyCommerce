using System.Collections.Generic;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
namespace StormyCommerce.Core.Entities.Vendor
{
    public class StormyVendor : BaseEntity
    {
        public StormyVendor(long id)
        {
            Id = id;
        }
        public StormyVendor(){}        

        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }     
        public long VendorAddressId { get; set; }        
        public VendorAddress Address { get; set; }
        public long ProductId { get; set; }
        public List<StormyProduct> Products { get; set; } = new List<StormyProduct>();
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string TypeGoods { get; set; }
        public string SizeUrl { get; set; }
        public string Logo { get; set; }
        public string Note { get; set; }
    }
}
