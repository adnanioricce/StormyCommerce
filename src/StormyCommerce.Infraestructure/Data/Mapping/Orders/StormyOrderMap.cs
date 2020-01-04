using Microsoft.EntityFrameworkCore;
namespace StormyCommerce.Infraestructure.Data.Mapping.Orders
{
    public class OrderMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Payment>(entity =>
            //{
            //    entity.HasKey(prop => prop.Id);                
            //    entity.HasQueryFilter(prop => prop.IsDeleted == false);                
            //});
            //modelBuilder.Entity<Order>(order =>
            //{
            //    order.HasOne(prop => prop.Payment)
            //        //.WithOne(prop => prop.Order)
            //        .WithOne()
            //        .HasForeignKey<Payment>(prop => prop.OrderId)
            //        .OnDelete(DeleteBehavior.Restrict);
            //    order.HasOne(prop => prop.Shipment)
            //        .WithOne(prop => prop.Order)
            //        .HasForeignKey<StormyShipment>(prop => prop.OrderId)
            //        .OnDelete(DeleteBehavior.Restrict);
            //    order.HasOne(prop => prop.Customer)
            //    .WithMany()
            //    .HasForeignKey(prop => prop.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);                
            //    order.Property(prop => prop.OrderUniqueKey).IsRequired();                
            //    order.Property(prop => prop.Note).HasMaxLength(1000);                 
            //    order.HasQueryFilter(prop => prop.IsDeleted == false);
            //    order.Property(prop => prop.Id).ValueGeneratedOnAdd().UseNpgsqlIdentityByDefaultColumn();
            //});
            //modelBuilder.Entity<OrderItem>(orderItem =>
            //{
            //    // orderItem.HasKey(prop => new {prop.Id,prop.OrderId});
            //    orderItem.HasOne(prop => prop.Order).WithMany(order => order.Items).HasForeignKey(o => o.OrderId);
            //    orderItem.Property(prop => prop.Price);                    
            //    orderItem.HasQueryFilter(prop => prop.IsDeleted == false);
            //});
        }
    }
}
