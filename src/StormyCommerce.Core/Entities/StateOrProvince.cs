using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Address
{
    public class StateOrProvince : EntityBase
    {
        public StateOrProvince()
        {

        }

        public StateOrProvince(long id)
        {
            Id = id;
        }        
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }        
        public string Code { get; set; }        
        public string Name { get; set; }        
        public string Type { get; set; }
    }
}
