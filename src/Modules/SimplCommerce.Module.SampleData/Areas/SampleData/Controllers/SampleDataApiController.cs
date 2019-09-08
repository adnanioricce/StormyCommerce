using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Infraestructure.Data;
using System;

namespace SimplCommerce.Module.SampleData.Areas.SampleData.Controllers
{
    [Area("SampleData")]
    [ApiController]
    [Route("[Controller]/api/")]
    public class SampleDataApiController : Controller
    {
        private readonly StormyDbContext _stormyDbContext;

        public SampleDataApiController(StormyDbContext stormyDbContext)
        {
            _stormyDbContext = stormyDbContext;
        }

        [HttpGet("/seed")]
        public void SeedDatabase()
        {
            try
            {
                _stormyDbContext.SeedDbContext();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
