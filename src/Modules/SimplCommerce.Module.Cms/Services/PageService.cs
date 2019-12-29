﻿using System.Threading.Tasks;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Cms.Models;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;

namespace SimplCommerce.Module.Cms.Services
{
    public class PageService : IPageService
    {
        public const string PageEntityTypeId = "Page";

        private readonly IStormyRepository<Page> _pageRepository;
        private readonly IEntityService _entityService;

        public PageService(IStormyRepository<Page> pageRepository, IEntityService entityService)
        {
            _pageRepository = pageRepository;
            _entityService = entityService;
        }

        public async Task Create(Page page)
        {            
            page.Slug = _entityService.ToSafeSlug(page.Slug, page.Id, PageEntityTypeId);
            await _pageRepository.AddAsync(page);                
            _entityService.Add(page.Name, page.Slug, page.Id, PageEntityTypeId);                
        }

        public async Task Update(Page page)
        {
            page.Slug = _entityService.ToSafeSlug(page.Slug, page.Id, PageEntityTypeId);
            _entityService.Update(page.Name, page.Slug, page.Id, PageEntityTypeId);
            await _pageRepository.SaveChangesAsync();
        }

        public async Task Delete(Page page)
        {
            _pageRepository.Delete(page);
            await _entityService.DeleteAsync(page.Id, PageEntityTypeId);
            _pageRepository.SaveChanges();
        }
    }
}
