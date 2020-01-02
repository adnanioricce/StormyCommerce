﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Inventory.Models;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Inventory.Services
{
    public class StockService : IStockService
    {
        private readonly IStormyRepository<Stock> _stockRepository;
        private readonly IStormyRepository<Product> _productRepository;
        private readonly IStormyRepository<StockHistory> _stockHistoryRepository;

        public StockService(IStormyRepository<Stock> stockRepository, IStormyRepository<Product> productRepository, IStormyRepository<StockHistory> stockHistoryRepository)
        {
            _stockRepository = stockRepository;
            _productRepository = productRepository;
            _stockHistoryRepository = stockHistoryRepository;
        }

        public async Task AddAllProduct(Warehouse warehouse)
        {
            var stocks = await _productRepository.Query().Where(x => !x.HasOptions && x.VendorId == warehouse.VendorId)
                .GroupJoin(_stockRepository.Query().Where(x => x.WarehouseId == warehouse.Id),
                    product => product.Id, stock => stock.ProductId,
                    (product, stockCollection) => new {IsNew = !stockCollection.Any(), ProductId = product.Id})
                .Where(x => x.IsNew)
                .Select(x => new Stock
                {
                    ProductId = x.ProductId,
                    WarehouseId = warehouse.Id,
                    Quantity = 0
                }).ToArrayAsync();
            await _stockRepository.AddCollectionAsync(stocks);            
        }

        public async Task UpdateStock(StockUpdateRequest stockUpdateRequest)
        {
            var product = await _productRepository.Query().FirstOrDefaultAsync(x => x.Id == stockUpdateRequest.ProductId);
            var stock = await _stockRepository.Query().FirstOrDefaultAsync(x => x.ProductId == stockUpdateRequest.ProductId && x.WarehouseId == stockUpdateRequest.WarehouseId);

            stock.Quantity = stock.Quantity + stockUpdateRequest.AdjustedQuantity;
            product.UnitsInStock = product.UnitsInStock + stockUpdateRequest.AdjustedQuantity;
            var stockHistory = new StockHistory
            {
                ProductId = stockUpdateRequest.ProductId,
                WarehouseId = stockUpdateRequest.WarehouseId,
                AdjustedQuantity = stockUpdateRequest.AdjustedQuantity,
                Note = stockUpdateRequest.Note,
                CreatedById = stockUpdateRequest.UserId,
                CreatedOn = DateTimeOffset.Now,
            };

            _stockHistoryRepository.Add(stockHistory);
            await _stockHistoryRepository.SaveChangesAsync();
        }
    }
}
