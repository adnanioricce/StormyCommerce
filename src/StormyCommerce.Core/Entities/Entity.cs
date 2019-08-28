using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Core.Entities
{
    public class Entity : BaseEntity
    {
        public Entity(long id)
        {

        }
        public Entity()
        {
              
        }
        public string Slug { get; set; }        
        public string Name { get; set; }
        public long EntityId { get; set; }        
        public string EntityTypeId { get; set; }
        public EntityType EntityType { get; set; }        
    }
}
