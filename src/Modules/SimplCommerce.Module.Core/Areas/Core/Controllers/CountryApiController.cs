using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Web.SmartTable;
using SimplCommerce.Module.Core.Areas.Core.ViewModels;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities.Address;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Route("api/countries")]
    public class CountryApiController : Controller
    {
        private readonly IStormyRepository<Country> _countryRepository;

        public CountryApiController(IStormyRepository<Country> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]bool? shippingEnabled)
        {
            var query = _countryRepository.Query();
            if (shippingEnabled.HasValue)
            {
                query = query.Where(x => x.IsShippingEnabled == shippingEnabled.Value);
            }
            var countries = await query
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();
            return Json(countries);
        }

        [HttpPost("grid")]
        public IActionResult List([FromBody] SmartTableParam param)
        {
            var query = _countryRepository.Query();

            if (param.Search.PredicateObject != null)
            {
                dynamic search = param.Search.PredicateObject;

                if (search.Name != null)
                {
                    string name = search.Name;
                    query = query.Where(x => x.Name.Contains(name));
                }
            }

            var countries = query.ToSmartTableResult(
                param,
                c => new
                {
                    c.Id,
                    c.Name,
                    c.Code,
                    c.IsShippingEnabled,
                    c.IsBillingEnabled,
                    c.IsCityEnabled,
                    c.IsZipCodeEnabled,
                    c.IsDistrictEnabled
                });

            return Json(countries);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var country = await _countryRepository.Query().FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            var model = new CountryForm
            {
                Id = country.Id,
                Name = country.Name,
                Code3 = country.Code,
                IsBillingEnabled = country.IsBillingEnabled,
                IsShippingEnabled = country.IsShippingEnabled,
                IsCityEnabled = country.IsCityEnabled,
                IsZipCodeEnabled = country.IsZipCodeEnabled,
                IsDistrictEnabled = country.IsDistrictEnabled
            };

            return Json(model);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Put(string id, [FromBody] CountryForm model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var country = await _countryRepository.Query().FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            country.Name = model.Name;
            country.Code = model.Code3;
            country.IsShippingEnabled = model.IsShippingEnabled;
            country.IsBillingEnabled = model.IsBillingEnabled;
            country.IsCityEnabled = model.IsCityEnabled;
            country.IsZipCodeEnabled = model.IsZipCodeEnabled;
            country.IsDistrictEnabled = model.IsDistrictEnabled;

            await _countryRepository.SaveChangesAsync();

            return Accepted();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Post([FromBody] CountryForm model)
        {
            if (ModelState.IsValid)
            {
                var country = new Country(model.Id)
                {
                    Name = model.Name,
                    Code = model.Code3,
                    IsBillingEnabled = model.IsBillingEnabled,
                    IsShippingEnabled = model.IsShippingEnabled,
                    IsCityEnabled = model.IsCityEnabled,
                    IsZipCodeEnabled = model.IsZipCodeEnabled,
                    IsDistrictEnabled = model.IsDistrictEnabled
            };

                await _countryRepository.AddAsync(country);                

                return CreatedAtAction(nameof(Get), new { id = country.Id }, null);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(string id)
        {
            var country = await _countryRepository.Query().FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            try
            {
                _countryRepository.Delete(country);                
            }
            catch (DbUpdateException)
            {
                return BadRequest(new { Error = $"The country {country.Name} can't not be deleted because it is referenced by other tables" });
            }

            return NoContent();
        }
    }
}
