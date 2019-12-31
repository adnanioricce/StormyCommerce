using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Areas.Core.ViewModels;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Address;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Core.Areas.Core.Controllers
{
    [Area("Core")]
    [Authorize]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class UserAddressController : Controller
    {
        private readonly IStormyRepository<CustomerAddress> _userAddressRepository;
        private readonly IStormyRepository<Country> _countryRepository;
        private readonly IStormyRepository<StateOrProvince> _stateOrProvinceRepository;
        private readonly IStormyRepository<District> _districtRepository;
        private readonly IStormyRepository<User> _userRepository;
        private readonly IWorkContext _workContext;

        public UserAddressController(IStormyRepository<CustomerAddress> userAddressRepository, IStormyRepository<Country> countryRepository, IStormyRepository<StateOrProvince> stateOrProvinceRepository,
            IStormyRepository<District> districtRepository, IStormyRepository<User> userRepository, IWorkContext workContext)
        {
            _userAddressRepository = userAddressRepository;
            _countryRepository = countryRepository;
            _stateOrProvinceRepository = stateOrProvinceRepository;
            _districtRepository = districtRepository;
            _userRepository = userRepository;
            _workContext = workContext;
        }

        [Route("user/address")]
        public async Task<IActionResult> List()
        {
            var currentUser = await _workContext.GetCurrentUser();
            var model = _userAddressRepository
                .Query()
                .Where(x => x.Type == AddressType.Shipping && x.UserId == currentUser.Id)
                .Select(x => new UserAddressListItem
                {                    
                    UserAddressId = x.Id,
                    ContactName = x.WhoReceives,
                    Phone = x.Details.Phone.FullNumber,
                    AddressLine1 = x.Details.AddressLine1,
                    AddressLine2 = x.Details.AddressLine2,
                    DistrictName = x.Details.DistrictName,
                    StateOrProvinceName = x.Details.State,
                    CountryName = x.Details.CountryCode,
                    DisplayCity = true,
                    DisplayZipCode = true,
                    DisplayDistrict = true
                }).ToList();

            foreach (var item in model)
            {
                item.IsDefaultShippingAddress = item.UserAddressId == currentUser.DefaultShippingAddressId;
            }

            return View(model);
        }

        [HttpGet("api/country-states-provinces/{countryId}")]
        public async Task<IActionResult> Get(string countryId)
        {
            var country = await _countryRepository.Query().Include(x => x.StatesOrProvinces).FirstOrDefaultAsync(x => x.Id == countryId);
            if (country == null)
            {
                return NotFound();
            }

            var model = new
            {
                CountryId = country.Id,
                CountryName = country.Name,
                country.IsBillingEnabled,
                country.IsShippingEnabled,
                country.IsCityEnabled,
                country.IsZipCodeEnabled,
                country.IsDistrictEnabled,
                StatesOrProvinces = country.StatesOrProvinces.Select(x => new { x.Id, x.Name })
            };

            return Json(model);
        }

        [Route("user/address/create")]
        public IActionResult Create()
        {
            var model = new UserAddressFormViewModel();

            PopulateAddressFormData(model);

            return View(model);
        }
        //! use git to see the previous implementations of Create and edit
        [Route("user/address/create")]
        [HttpPost]
        public async Task<IActionResult> Create(UserAddressFormViewModel model)
        {
            throw new NotImplementedException();
        }

        [Route("user/address/edit/{id}")]
        public async Task<IActionResult> Edit(long id)
        {
            throw new NotImplementedException();
        }

        [Route("user/address/edit/{id}")]
        [HttpPost]
        public async Task<IActionResult> Edit(long id, UserAddressFormViewModel model)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> SetAsDefault(long id)
        {
            var currentUser = await _workContext.GetCurrentUser();

            var userAddress = _userAddressRepository.Query()
                .FirstOrDefault(x => x.Id == id && x.UserId == currentUser.Id);

            if (userAddress == null)
            {
                return NotFound();
            }

            currentUser.DefaultShippingAddressId = userAddress.Id;
            _userRepository.SaveChanges();

            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var currentUser = await _workContext.GetCurrentUser();

            var userAddress = _userAddressRepository.Query()
                .FirstOrDefault(x => x.Id == id && x.UserId == currentUser.Id);

            if (userAddress == null)
            {
                return NotFound();
            }

            if (currentUser.DefaultShippingAddressId == userAddress.Id)
            {
                currentUser.DefaultShippingAddressId = null;
            }

            _userAddressRepository.Delete(userAddress);
            _userAddressRepository.SaveChanges();

            return RedirectToAction("List");
        }

        private void PopulateAddressFormData(UserAddressFormViewModel model)
        {
            var shippableCountries = _countryRepository.Query()
                .Where(x => x.IsShippingEnabled)
                .OrderBy(x => x.Name);

            if (!shippableCountries.Any())
            {
                return;
            }

            model.Countries = shippableCountries
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            var selectedShipableCountryId = !string.IsNullOrEmpty(model.CountryId) ? model.CountryId : model.Countries.First().Value;
            var selectedCountry = shippableCountries.FirstOrDefault(c => c.Id == selectedShipableCountryId);
            if (selectedCountry != null)
            {
                model.DisplayCity = selectedCountry.IsCityEnabled;
                model.DisplayDistrict = selectedCountry.IsDistrictEnabled;
                model.DisplayZipCode = selectedCountry.IsZipCodeEnabled;
            }

            model.StateOrProvinces = _stateOrProvinceRepository
                .Query()
                .Where(x => x.CountryId == selectedShipableCountryId)
                .OrderBy(x => x.Name)
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                }).ToList();

            if (model.StateOrProvinceId > 0)
            {
                model.Districts = _districtRepository
                    .Query()
                    .Where(x => x.StateOrProvinceId == model.StateOrProvinceId)
                    .OrderBy(x => x.Name)
                    .Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }).ToList();
            }
        }
    }
}
