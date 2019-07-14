using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data
{
    public class EntityTypeConfiguration<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        protected virtual void CustomConfiguration(EntityTypeBuilder<TEntity> builder)
        {
        }
        public virtual void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            CustomConfiguration(builder);
        }       
    }
}
