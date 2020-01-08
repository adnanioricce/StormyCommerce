using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Settings;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace SimplCommerce.Module.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Authorize(Roles = "admin")]
    [Route("api/entity-types")]
    public class EntityTypeApiController : Controller
    {
        private readonly IRepositoryWithTypedId<EntityType,string> _entityTypeRepository;

        public EntityTypeApiController(IRepositoryWithTypedId<EntityType,string> entityTypeRepository)
        {
            _entityTypeRepository = entityTypeRepository;
        }

        [HttpGet("menuable")]
        public IActionResult GetMenuable()
        {
            var entityTypes = _entityTypeRepository.Query()
                .Where(x => x.IsMenuable)
                .Select(x => new
                {
                    x.Id,
                    x.AreaName
                });

            return Ok(entityTypes);
        }
    }
}
