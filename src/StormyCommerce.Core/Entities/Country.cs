using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Address
{
    public class Country : EntityBaseWithTypedId<string>
    {
        public Country(string id)
        {
            Id = id;
        }
        public string Name { get; set; }        
        public string Code { get; set; }
        public bool IsBillingEnabled { get; set; }
        public bool IsShippingEnabled { get; set; }
        public bool IsCityEnabled { get; set; } = true;
        public bool IsZipCodeEnabled { get; set; } = true;
        public bool IsDistrictEnabled { get; set; } = true;
        public virtual IList<StateOrProvince> StatesOrProvinces { get; set; } = new List<StateOrProvince>();

    }
}
