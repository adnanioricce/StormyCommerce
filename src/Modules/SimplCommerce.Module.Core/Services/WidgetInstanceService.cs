using System;
using System.Linq;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Cms;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Core.Services
{
    public class WidgetInstanceService : IWidgetInstanceService
    {
        private IStormyRepository<WidgetInstance> _widgetInstanceRepository;

        public WidgetInstanceService(IStormyRepository<WidgetInstance> widgetInstanceRepository)
        {
            _widgetInstanceRepository = widgetInstanceRepository;
        }

        public IQueryable<WidgetInstance> GetPublished()
        {
            return _widgetInstanceRepository.Query().Where(x =>
                x.PublishStart.HasValue && x.PublishStart < DateTimeOffset.Now
                && (!x.PublishEnd.HasValue || x.PublishEnd > DateTimeOffset.Now));
        }
    }
}
