using System.Linq;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Cms;

namespace SimplCommerce.Module.Core.Services
{
    public interface IWidgetInstanceService
    {
        IQueryable<WidgetInstance> GetPublished();
    }
}
