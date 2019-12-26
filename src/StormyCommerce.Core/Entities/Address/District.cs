using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities.Address
{
    public class District : EntityBase
    {
        public District() { }

        public District(long id)
        {
            Id = id;
        }
        public long StateOrProvinceId { get; set; }
        public StateOrProvince StateOrProvince { get; set; }        
        public string Name { get; set; }        
        public string Type { get; set; }
        public string Location { get; set; }
    }
}
