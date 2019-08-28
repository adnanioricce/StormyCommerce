using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Infraestructure.Data
{
    public interface IStormyModelBuilder
    {
        void Build(ModelBuilder modelBuilder);        
    }
}
