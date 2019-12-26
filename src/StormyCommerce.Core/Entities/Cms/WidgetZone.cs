using System;

namespace StormyCommerce.Core.Entities.Cms
{
    public class WidgetZone : EntityBase
    {
        public WidgetZone(long id)
        {
            Id = id;
        }
        
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
