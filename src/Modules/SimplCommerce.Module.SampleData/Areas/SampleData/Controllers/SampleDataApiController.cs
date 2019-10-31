using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Infraestructure.Data;
using System;
using StormyCommerce.Api.Framework.Extensions;
using System.Collections.Generic;
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
                var destinationAddresses = Seeders.AddressSeed(10);
                var billingAddresses = Seeders.AddressSeed(10);
                billingAddresses.ForEach(a => a.Id += 10);
                var reviews = Seeders.ReviewSeed(10);
                var stormyCustomers = Seeders.StormyCustomerSeed(10);                
                _stormyDbContext.AddRange(destinationAddresses);
                _stormyDbContext.AddRange(billingAddresses);
                _stormyDbContext.SaveChanges();
                _stormyDbContext.AddRange(reviews);
                _stormyDbContext.AddRange(stormyCustomers);
                _stormyDbContext.SaveChanges();
                _stormyDbContext.SeedDbContext();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // [HttpGet("dumpdatabase")]
        // public List<object> DumpDatabase()
        // {
        //     var data = new List<object>();

        // }
    }
}
