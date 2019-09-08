using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Services.Catalog
{
    public class ProductTemplateService : IProductTemplateService
    {
        private readonly IStormyRepository<ProductTemplate> _productTemplateRepository;
        private readonly IStormyRepository<ProductAttribute> _productAttributeRepository;
        private readonly IProductTemplateProductAttributeRepository _productTemplateProductAttributeRepository;

        //Why this exists?
        public ProductTemplateService(IStormyRepository<ProductTemplate> productTemplateRepository,
        IStormyRepository<ProductAttribute> productAttributeRepository,
        IProductTemplateProductAttributeRepository productTemplateProductAttribute)
        {
            _productTemplateRepository = productTemplateRepository;
            _productAttributeRepository = productAttributeRepository;
            _productTemplateProductAttributeRepository = productTemplateProductAttribute;
        }

        public async Task<ProductTemplate> GetProductTemplateByIdAsync(long id)
        {
            return await _productTemplateRepository.GetByIdAsync(id);
        }

        public async Task CreateProductTemplateAsync(ProductTemplate productTemplate)
        {
            await _productTemplateRepository.AddAsync(productTemplate);
        }

        //TODO:change all this to a DTO
        public async Task EditProductTemplateAsync(long id, ProductTemplate productTemplate)
        {
            var _template = _productTemplateRepository.Table
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
