using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;

namespace StormyCommerce.Core.Services
{
    public class BrandService : IBrandService
    {
        private const string BrandEntityTypeId = "Brand";
        private readonly IStormyRepository<Brand> _brandRepository;
        private readonly IEntityService _entityService;
        public BrandService(IStormyRepository<Brand> brandRepository,IEntityService entityService)
        {
            _brandRepository = brandRepository;
            _entityService = entityService;
        }
        public async Task AddAsync(Brand entity)
        {
            entity.Slug = _entityService.ToSafeSlug(entity.Slug, entity.Id, BrandEntityTypeId);
            await _brandRepository.AddAsync(entity);
            _entityService.Add(entity.Name,entity.Slug,entity.Id,BrandEntityTypeId);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _brandRepository.GetByIdAsync(id);
            _brandRepository.Delete(entity);            
        }
        //?Why use this?
        public async Task DeleteAsync(Brand entity)
        {
            entity.Deleted = true;
            _entityService.Delete(entity.Id, BrandEntityTypeId);
            _brandRepository.Delete(entity);
        }

        public async Task UpdateAsync(Brand entity)
        {
            entity.Slug = _entityService.ToSafeSlug(entity.Slug, entity.Id, BrandEntityTypeId);
            _entityService.Update(entity.Name, entity.Slug, entity.Id, BrandEntityTypeId);
            await _brandRepository.UpdateAsync(entity);
        }
    }
}
