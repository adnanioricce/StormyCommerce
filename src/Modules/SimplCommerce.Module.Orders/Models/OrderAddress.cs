using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;
using SimplCommerce.Module.Core.Models;

namespace SimplCommerce.Module.Orders.Models
{
    public class OrderAddress : EntityBase
    {
        public OrderAddress(){}
        public OrderAddress(Address address)
        {
            ContactName = address.ContactName;
            Phone = address.Phone;
            AddressLine1 = address.AddressLine1;
            AddressLine2 = address.AddressLine2;
            City = address.City;
            ZipCode = address.ZipCode;
            if(address.Country == null || !string.IsNullOrEmpty(address.CountryId))
                DistrictId = address.DistrictId;
            if (address.StateOrProvince == null || address.StateOrProvinceId > 0)
                StateOrProvinceId = address.StateOrProvinceId;
            if (address.District == null || address.DistrictId > 0)
                DistrictId = address.DistrictId;
        }
        [StringLength(450)]
        public string ContactName { get; set; }

        [StringLength(450)]
        public string Phone { get; set; }

        [StringLength(450)]
        public string AddressLine1 { get; set; }

        [StringLength(450)]
        public string AddressLine2 { get; set; }

        [StringLength(450)]
        public string City { get; set; }

        [StringLength(450)]
        public string ZipCode { get; set; }

        public long? DistrictId { get; set; }

        public District District { get; set; }

        public long StateOrProvinceId { get; set; }

        public StateOrProvince StateOrProvince { get; set; }

        [StringLength(450)]
        public string CountryId { get; set; }

        public Country Country { get; set; }
    }
}
