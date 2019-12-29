using StormyCommerce.Core.Entities.Customer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Infraestructure.Settings
{
    public interface ISettingService
    {
        Task<string> GetSettingValueAsync(string name);

        Task<string> GetSettingValueForAsync(long userId, string name);

        Task<Dictionary<string, string>> GetAllSettingsAsync();

        Task<Dictionary<string, string>> GetAllSettingsAsync(long userId);

        //The original ISettingService expects a User, what is different from use my customer entity instead?
        Task UpdateSettingForUserAsync(User customer, string name, string value);

        Task UpdateSettingAsync(string name, string value);

        void SetCustomSettingValueForUser(User customer, string name, string value);
    }
}
