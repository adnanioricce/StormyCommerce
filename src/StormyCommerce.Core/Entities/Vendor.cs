using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities
{
    public class Vendor : EntityBase
    {
        public Vendor()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Slug { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string TypeGoods { get; set; }
        public string SizeUrl { get; set; }
        public string Logo { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }        
        public virtual ICollection<VendorAddress> Addresses { get; set; } = new List<VendorAddress>();
        public virtual IList<User> Users { get; set; } = new List<User>();
    }
}
