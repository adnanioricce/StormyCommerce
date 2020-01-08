using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Cms;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace SimplCommerce.Module.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Authorize(Roles = "admin")]
    [Route("api/widget-instances")]
    public class WidgetInstanceApiController : Controller
    {
        private readonly IStormyRepository<WidgetInstance> _widgetInstanceRepository;
        private readonly IRepositoryWithTypedId<Widget,string> _widgetRespository;

        public WidgetInstanceApiController(IStormyRepository<WidgetInstance> widgetInstanceRepository,IRepositoryWithTypedId<Widget,string> widgetRespository)
        {
            _widgetInstanceRepository = widgetInstanceRepository;
            _widgetRespository = widgetRespository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var widgetInstances = await _widgetInstanceRepository.Query()
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    WidgetType = x.Widget.Name,
                    WidgetZone = x.WidgetZone.Name,
                    CreatedOn = x.CreatedOn,
                    EditUrl = x.Widget.EditUrl,
                    PublishStart = x.PublishStart,
                    PublishEnd = x.PublishEnd,
                    DisplayOrder = x.DisplayOrder,
                }).ToListAsync();

            return Json(widgetInstances);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var widgetInstance = await _widgetInstanceRepository.Query().FirstOrDefaultAsync(x => x.Id == id);
            if (widgetInstance == null)
            {
                return NotFound();
            }

            _widgetInstanceRepository.Delete(widgetInstance);
            _widgetInstanceRepository.SaveChanges();

            return NoContent();
        }

        [HttpGet("number-of-widgets")]
        public IActionResult GetNumberOfWidgets()
        {
            var total = _widgetInstanceRepository.Query().Count();

            return Json(total);
        }
    }
}
