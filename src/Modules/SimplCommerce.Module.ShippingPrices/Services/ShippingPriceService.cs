﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimplCommerce.Module.Shipping.Models;
using StormyCommerce.Core.Entities.Address;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace SimplCommerce.Module.ShippingPrices.Services
{
    public class ShippingPriceService : IShippingPriceService
    {
        private HttpContext _httpContext;
        private readonly IRepositoryWithTypedId<ShippingProvider, string> _shippingProviderRepository;
        private readonly IRepositoryWithTypedId<Country,string> _countryRepository;
        private readonly IStormyRepository<StateOrProvince> _stateOrProvinceRepository;

        public ShippingPriceService(IHttpContextAccessor contextAccessor, 
            IRepositoryWithTypedId<ShippingProvider, string> shippingProviderRepository,
            IRepositoryWithTypedId<Country,string> countryRepository,
            IStormyRepository<StateOrProvince> stateOrProvinceRepository
            )
        {
            _httpContext = contextAccessor.HttpContext;
            _shippingProviderRepository = shippingProviderRepository;
            _countryRepository = countryRepository;
            _stateOrProvinceRepository = stateOrProvinceRepository;
        }

        public async Task<IList<ShippingPrice>> GetApplicableShippingPrices(GetShippingPriceRequest request)
        {
            var applicableShippingPrices = new List<ShippingPrice>();
            var providers = await _shippingProviderRepository.Query().ToListAsync();
            var shippingRateServices = _httpContext.RequestServices.GetServices<IShippingPriceServiceProvider>();

            foreach(var provider in providers)
            {
                if(!provider.IsEnabled)
                {
                    continue;
                }
                var country = await _countryRepository.Query()
                    .Where(c => string.Equals(c.Id,request.ShippingAddress.CountryId,StringComparison.CurrentCultureIgnoreCase))
                    .FirstOrDefaultAsync();
                if (!provider.ToAllShippingEnabledCountries)
                {

                    if (!provider.OnlyCountryIds.Contains(request.ShippingAddress.CountryId))
                    {
                        continue;
                    }
                }

                if (!provider.ToAllShippingEnabledStatesOrProvinces)
                {
                    if (!provider.OnlyStateOrProvinceIds.Contains(request.ShippingAddress.StateOrProvinceId))
                    {
                        continue;
                    }
                }

                var priceServiceType = Type.GetType(provider.ShippingPriceServiceTypeName);
                var priceService = shippingRateServices.Where(x => x.GetType() == priceServiceType).FirstOrDefault();
                var response = await priceService.GetShippingPrices(request, provider);
                applicableShippingPrices.AddRange(response.ApplicablePrices);
            }

            return applicableShippingPrices;
        }
    }
}
