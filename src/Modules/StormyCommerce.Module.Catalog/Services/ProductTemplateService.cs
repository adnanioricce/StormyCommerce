using Microsoft.EntityFrameworkCore;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.Catalog.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Services
{
    public class ProductTemplateService : IProductTemplateService
    {
        private readonly IStormyRepository<ProductTemplate> _productTemplateRepository;        
        private readonly IProductTemplateProductAttributeRepository _productTemplateProductAttributeRepository;

        //Why this exists?
        public ProductTemplateService(IStormyRepository<ProductTemplate> productTemplateRepository,            
            IProductTemplateProductAttributeRepository productTemplateProductAttribute)
        {
            _productTemplateRepository = productTemplateRepository;            
            _productTemplateProductAttributeRepository = productTemplateProductAttribute;
        }

        public async Task<Result<ProductTemplate>> GetProductTemplateByIdAsync(long id)
        {
            return Result.Ok(await _productTemplateRepository.GetByIdAsync(id));
        }

        public async Task<Result> CreateProductTemplateAsync(ProductTemplate productTemplate)
        {
            await _productTemplateRepository.AddAsync(productTemplate);
            return Result.Ok();
        }

        //TODO:change all this to a DTO
        public async Task<Result> EditProductTemplateAsync(long id, ProductTemplate productTemplate)
        {
            var _template = _productTemplateRepository.Query()
            .Include(attributes => attributes.ProductAttributes)
            .Where(template => template.Id == id)
            .FirstOrDefault();
            _template.Name = productTemplate.Name;
            foreach (var _attribute in _template.ProductAttributes)
            {
                if (productTemplate.ProductAttributes.Any(attrib => attrib.ProductAttributeId == _attribute.ProductAttributeId))
                    continue;

                _template.AddAttribute(_attribute.ProductAttributeId);
            }
            var deletedAttributes = productTemplate.ProductAttributes
            .Where(attrib => !productTemplate.ProductAttributes
            .Select(atr => atr.ProductAttributeId)
            .Contains(attrib.ProductAttributeId));
            foreach (var deletedAttribute in deletedAttributes)
            {
                deletedAttribute.ProductTemplate = null;
                //!s NOT IMPLEMENTED
                await _productTemplateProductAttributeRepository.UpdateAsync(deletedAttribute);
            }
            return Result.Ok();
        }

        public async Task DeleteProductTemplate(long id)
        {
            var productTemplate = await _productTemplateRepository.GetByIdAsync(id);
            if (productTemplate == null)
                return;

            _productTemplateRepository.Delete(productTemplate);
        }

        // public async Task
    }
}
