using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.Stock
{
    public class StockMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<StormyStock>(e => {
            //    e.Property(prop => prop.Id).ValueGeneratedOnAdd();
            //});
        }
    }
}
