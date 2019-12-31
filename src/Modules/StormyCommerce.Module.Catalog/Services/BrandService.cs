
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Module.Catalog.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Services
{
    public class BrandService : IBrandService
    {
        private const string BrandEntityTypeId = "Brand";
        private readonly IStormyRepository<Brand> _brandRepository;
        private readonly IEntityService _entityService;

        public BrandService(IStormyRepository<Brand> brandRepository, IEntityService entityService)
        {
            _brandRepository = brandRepository;
            _entityService = entityService;
        }

        public async Task<Brand> GetBrandByIdAsync(long id)
        {
            return await _brandRepository.GetByIdAsync(id);
        }

        public async Task<IList<Brand>> GetAllBrandsAsync()
        {
            return await _brandRepository.GetAllAsync();
        }

        public async Task AddAsync(Brand entity)
        {
            if (string.IsNullOrEmpty(entity.Slug)) entity.Slug = "";
            entity.Slug = _entityService.ToSafeSlug(entity.Slug, entity.Id, BrandEntityTypeId);
            await _brandRepository.AddAsync(entity);
            _entityService.Add(entity.Name, entity.Slug, entity.Id, BrandEntityTypeId);
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await _brandRepository.GetByIdAsync(id);
            entity.IsDeleted = true;
            await _brandRepository.UpdateAsync(entity);
        }

        //?Why use this?
        public async Task DeleteAsync(Brand entity)
        {
            entity.IsDeleted = true;
            await _entityService.DeleteAsync(entity.Id, BrandEntityTypeId);
            await _brandRepository.UpdateAsync(entity);
        }

        public async Task UpdateAsync(Brand entity)
        {
            entity.Slug = _entityService.ToSafeSlug(entity.Slug, entity.Id, BrandEntityTypeId);
            _entityService.Update(entity.Name, entity.Slug, entity.Id, BrandEntityTypeId);
            await _brandRepository.UpdateAsync(entity);
        }
    }
}
