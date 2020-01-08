using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Settings;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace SimplCommerce.Module.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Authorize(Roles = "admin")]
    [Route("api/AppSettingss")]
    public class AppSettingsApiController : Controller
    {
        private readonly IRepositoryWithTypedId<AppSettings,string> _AppSettingsRepository;
        private readonly IConfigurationRoot _configurationRoot;

        public AppSettingsApiController(IRepositoryWithTypedId<AppSettings,string> AppSettingsRepository, IConfiguration configuration)
        {
            _AppSettingsRepository = AppSettingsRepository;
            _configurationRoot = (IConfigurationRoot)configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var settings = await _AppSettingsRepository.Query().Where(x => x.IsVisibleInCommonSettingPage).ToListAsync();
            return Json(settings);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] IList<AppSettings> model)
        {
            if (ModelState.IsValid)
            {
                var settings = await _AppSettingsRepository.Query().Where(x => x.IsVisibleInCommonSettingPage).ToListAsync();
                foreach(var item in settings)
                {
                    var vm = model.FirstOrDefault(x => x.Id == item.Id);
                    if (vm != null)
                    {
                        item.Value = vm.Value;
                    }
                }

                await _AppSettingsRepository.SaveChangesAsync();
                _configurationRoot.Reload();

                return Accepted();
            }

            return BadRequest(ModelState);
        }
    }
}
