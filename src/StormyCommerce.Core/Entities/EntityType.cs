using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities
{
    public class EntityType : EntityWithBaseTypeId<string>
    {
        public EntityType()
        {

        }
        public EntityType(string id)
        {
            Id = id;
        }                
        public bool IsMenuable { get; set; }       
        public string AreaName { get; set; }        
        public string RoutingController { get; set; }        
        public string RoutingAction { get; set; }
        public bool IsDeleted { get; set; }
    }
}
