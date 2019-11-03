using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using StormyCommerce.Core.Entities.Settings;

namespace SimplCommerce.Module.EmailSenderSmtp.Data
{
    public class EmailSenderSmptCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSettings>().HasData(
                new AppSettings("SmtpServer") { Module = "EmailSenderSmpt", IsVisibleInCommonSettingPage = false, Value = "smtp.gmail.com" },
                new AppSettings("SmtpPort") { Module = "EmailSenderSmpt", IsVisibleInCommonSettingPage = false, Value = "587" },
                new AppSettings("SmtpUsername") { Module = "EmailSenderSmpt", IsVisibleInCommonSettingPage = false, Value = "" },
                new AppSettings("SmtpPassword") { Module = "EmailSenderSmpt", IsVisibleInCommonSettingPage = false, Value = "" }
            );
        }
    }
}
