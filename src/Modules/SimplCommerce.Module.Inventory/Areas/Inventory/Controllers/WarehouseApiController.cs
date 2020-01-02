using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Web.SmartTable;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Inventory.Areas.Inventory.ViewModels;
using SimplCommerce.Module.Inventory.Models;
using StormyCommerce.Core.Entities.Address;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Inventory.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    [Authorize(Roles = "admin, vendor")]
    [Route("api/warehouses")]
    public class WarehouseApiController : Controller
    {
        private readonly IStormyRepository<Warehouse> _warehouseRepository;
        private readonly IStormyRepository<Address> _addressRepository;
        private readonly IStormyRepository<StateOrProvince> _stateOrProvinceRepository;
        private readonly IStormyRepository<Country> _countryRepository;
        private readonly IStormyRepository<District> _districtRepository;
        private readonly IWorkContext _workContext;

        public WarehouseApiController(IStormyRepository<Warehouse> warehouseRepository, IWorkContext workContext, IStormyRepository<Address> addressRepository,
            IStormyRepository<StateOrProvince> stateOrProvinceRepository, IStormyRepository<Country> countryRepository, IStormyRepository<District> districtRepository)
        {
            _warehouseRepository = warehouseRepository;
            _addressRepository = addressRepository;
            _workContext = workContext;
            _stateOrProvinceRepository = stateOrProvinceRepository;
            _countryRepository = countryRepository;
            _districtRepository = districtRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = _warehouseRepository.Query();
            var currentUser = await _workContext.GetCurrentUser();
            if (!User.IsInRole("admin"))
            {
                query = query.Where(x => x.VendorId == currentUser.VendorId);
            }

            var warehouses = await query.Select(x => new
            {
                x.Id,
                x.Name
            }).ToListAsync();

            return Ok(warehouses);
        }

        [HttpPost("grid")]
        public async Task<IActionResult> List([FromBody] SmartTableParam param)
        {
            var query = _warehouseRepository.Query();
            if (param.Search.PredicateObject != null)
            {
                dynamic search = param.Search.PredicateObject;

                if (search.Name != null)
                {
                    string name = $"%{search.Name}%";
                    query = query.Where(x => EF.Functions.Like(x.Name, name));
                }
            }

            var currentUser = await _workContext.GetCurrentUser();
            if (!User.IsInRole("admin"))
            {
                query = query.Where(x => x.VendorId == currentUser.VendorId);
            }

            var warehouses = query.ToSmartTableResult(
                param,
                 sp => new
                 {
                     sp.Id,
                     sp.Name,
                     VendorName = sp.Vendor.Name
                 });

            return Json(warehouses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var warehouse = await _warehouseRepository.Query().Include(w => w.Address).FirstOrDefaultAsync(w => w.Id == id);
            if (warehouse == null)
            {
                return NotFound();
            }

            var currentUser = await _workContext.GetCurrentUser();
            if (!User.IsInRole("admin") && warehouse.VendorId != currentUser.VendorId)
            {
                return BadRequest(new { error = "You don't have permission to manage this warehouse" });
            }

            var address = warehouse.Address ?? new Address();
            var model = new WarehouseVm
            {
                Id = warehouse.Id,
                Name = warehouse.Name,
                AddressId = address.Id,
                ContactName = address.ContactName,
                AddressLine1 = address.Detail.AddressLine1,
                AddressLine2 = address.Detail.AddressLine2,
                Phone = address.Phone,
                StateOrProvinceId = address.StateOrProvinceId,
                CountryId = address.CountryId,
                City = address.Detail.City,
                DistrictId = address.DistrictId,
                ZipCode = address.Detail.ZipCode
            };

            return Json(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WarehouseVm model)
        {
            if (ModelState.IsValid)
            {
                var country = await _countryRepository.GetByIdAsync(model.CountryId);
                var state = await _countryRepository.GetByIdAsync(model.StateOrProvinceId);
                var district = await _countryRepository.GetByIdAsync(model.DistrictId);
                var address = new Address
                {                    
                    Detail = new AddressDetail(country.Name, state.Name, model.City, district.Name, "?", model.AddressLine1, model.AddressLine2, model.ZipCode, "?", "?", model.ContactName, model.Phone),                    
                };

                var warehouse = new Warehouse
                {
                    Name = model.Name,
                    Address = address
                };

                var currentUser = await _workContext.GetCurrentUser();
                if (!User.IsInRole("admin"))
                {
                    warehouse.VendorId = currentUser.VendorId;
                }

                _warehouseRepository.Add(warehouse);
                await _warehouseRepository.SaveChangesAsync();
                return CreatedAtAction(nameof(Get), new { id = warehouse.Id }, null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] WarehouseVm model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var warehouse = await _warehouseRepository.Query()
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (warehouse == null)
            {
                return NotFound();
            }

            var currentUser = await _workContext.GetCurrentUser();
            if (!User.IsInRole("admin") && warehouse.VendorId != currentUser.VendorId)
            {
                return BadRequest(new { error = "You don't have permission to manage this warehouse" });
            }

            warehouse.Name = model.Name;
            if (warehouse.Address == null)
            {
                warehouse.Address = new Address();
                _addressRepository.Add(warehouse.Address);
            }

            warehouse.Address.ContactName = model.ContactName;
            warehouse.Address.Phone = model.Phone;
            warehouse.Address.Detail = new AddressDetail("","","","","","","",model.ZipCode,"","","","");
            warehouse.Address.StateOrProvinceId = model.StateOrProvinceId;
            warehouse.Address.CountryId = model.CountryId;
            warehouse.Address.DistrictId = model.DistrictId;

            await _warehouseRepository.SaveChangesAsync();
            return Accepted();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var warehouse = await _warehouseRepository.Query().Include(w => w.Address).FirstOrDefaultAsync(x => x.Id == id);
            if (warehouse == null)
            {
                return NotFound();
            }

            var currentUser = await _workContext.GetCurrentUser();
            if (!User.IsInRole("admin") && warehouse.VendorId != currentUser.VendorId)
            {
                return BadRequest(new { error = "You don't have permission to manage this warehouse" });
            }

            try
            {
                _warehouseRepository.Delete(warehouse);
                _addressRepository.Delete(warehouse.Address);

                await _warehouseRepository.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return BadRequest(new { Error = $"The warehouse {warehouse.Name} can't not be deleted because it is referenced by other tables" });
            }

            return NoContent();
        }
    }
}
