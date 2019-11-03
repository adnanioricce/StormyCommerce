using System;

namespace StormyCommerce.Core.Entities
{
    public class BaseEntity : EntityWithBaseTypeId<long>
    {
        public BaseEntity(bool isDeleted = false)
        {
            IsDeleted = isDeleted;
        }

        public virtual DateTimeOffset LastModified { get; set; } = DateTimeOffset.UtcNow;
        public virtual bool IsDeleted { get; set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as BaseEntity;
            if (ReferenceEquals(this, compareTo))
                return true;
            if (compareTo is null)
                return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(BaseEntity a, BaseEntity b)
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
