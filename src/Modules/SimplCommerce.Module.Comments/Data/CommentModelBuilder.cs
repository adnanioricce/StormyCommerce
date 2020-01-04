using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Settings;

namespace SimplCommerce.Module.Comments.Data
{
    public class CommentCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSettings>().HasData(
                new AppSettings("Catalog.IsCommentsRequireApproval") { Module = "Catalog", IsVisibleInCommonSettingPage = true, Value = "true" }
            );
        }
    }
}
