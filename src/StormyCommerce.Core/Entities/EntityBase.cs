using System;

namespace StormyCommerce.Core.Entities
{
    public abstract class EntityBase : EntityBaseWithTypedId<long>
    {
        public EntityBase(bool isDeleted = false)
        {
            IsDeleted = isDeleted;
        }

        public virtual DateTimeOffset LastModified { get; set; } = DateTimeOffset.UtcNow;
        public virtual DateTimeOffset CreatedOn { get; set; } 
        public virtual bool IsDeleted { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityBase;
            if (ReferenceEquals(this, compareTo))
                return true;
            if (compareTo is null)
                return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }
    }
}
