using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Settings;

namespace SimplCommerce.Module.Contacts.Data
{
    public class ContactCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSettings>().HasData(
                new AppSettings("GoogleAppKey") { Module = "Contact", IsVisibleInCommonSettingPage = false, Value = "" }
            );
        }
    }
}
