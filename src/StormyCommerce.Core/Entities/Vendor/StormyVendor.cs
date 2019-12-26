using System.Collections.Generic;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Entities.Vendor
{
    public class StormyVendor : EntityBase
    {
        public StormyVendor(long id)
        {
            Id = id;
        }
        public StormyVendor(){}        
        public bool IsActive { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }     
        public string Slug { get; set; }
        public long VendorAddressId { get; set; }        
        public virtual ICollection<VendorAddress> Addresses { get; set; } = new List<VendorAddress>();
        public long ProductId { get; set; }
        public virtual List<StormyProduct> Products { get; set; } = new List<StormyProduct>();
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string TypeGoods { get; set; }
        public string SizeUrl { get; set; }
        public string Logo { get; set; }                
        public string Note { get; set; }
        public ICollection<StormyCustomer> Users { get; set; } = new List<StormyCustomer>();
    }
}
