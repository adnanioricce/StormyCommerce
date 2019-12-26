namespace StormyCommerce.Core.Entities
{
    public class Entity : EntityBase
    {        
        public Entity(){}

        public string Slug { get; set; }
        public string Name { get; set; }
        public long EntityId { get; set; }
        public string EntityTypeId { get; set; }
        public virtual EntityType EntityType { get; set; }
    }
}
