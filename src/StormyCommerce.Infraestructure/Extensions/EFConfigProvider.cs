using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StormyCommerce.Infraestructure.Data;
using System;
using System.Linq;

namespace StormyCommerce.Infraestructure.Extensions
{
    public class EFConfigProvider : ConfigurationProvider
    {
        private Action<DbContextOptionsBuilder> OptionsAction { get; }

        public EFConfigProvider(Action<DbContextOptionsBuilder> optionsAction)
        {
            OptionsAction = optionsAction;
        }

        public override void Load()
        {
            var builder = new DbContextOptionsBuilder<EFConfigurationDbContext>();
            OptionsAction(builder);

            using(var dbContext = new EFConfigurationDbContext(builder.Options)){  
                if(dbContext.Database.EnsureCreated()){                                                                
                    Data = dbContext.AppSettings.ToDictionary(c => c.Id, c => c.Value);
                }
            }
        }
    }
}
