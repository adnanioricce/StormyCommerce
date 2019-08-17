namespace StormyCommerce.Infraestructure.Helpers
{
    //TODO:Instead of doing this job by hand, find a way to start generate repetitive code
    //?Code snippets?Regex?Shell scripts?
    public static class Seeders
    {
        public static Faker<StormyProduct> StormyProductSeed()
        {
            var fakeProduct = new Faker<StormyProduct>()
                .RuleFor(v => v.Id,f => f.IndexVariable++);
                .RuleFor(v => v.Sku, f => f.Name)]
                //Try to get Random Categories And so on
                .RuleFor(v => v.Slug,f => $"{f.Name}-{f.Name}-{f.Name}")
                .RuleFor(v => v.TypeName, f => f.Name)
                .RuleFor(v => v.QuantityPerUnity, f => f.Number)
                .RuleFor(v => v.UnitSize,f => f.DecimalValue)
                .RuleFor(v => v.UnitPrice,f => f.Money)
                .RuleFor(v => v.Discount,f => v.UnitPrice - (v.UnitPrice/f.Money))
                .RuleFor(v => v.UnitWeight, f => f.Weight)
                .RuleFor(v => v.UnitsInStock,f => f.Number)
                .RuleFor(v => v.UnitsOnOrder,f => f.Number)
                .RuleFor(v => v.ProductAvailable,true)
                .RuleFor(v => v.DiscountAvailable,f => f.booleanValue)
                .RuleFor(v => v.StockTrackingEnable,true)
                .RuleFor(v => v.Ranking,f => f.IndexVariable)
                .RuleFor(v => v.Note,f => f.Text)
                .RuleFor(v => v.Price,f => f.Money)
                .RuleFor(v => v.OldPrice,f => f.Money)
                .RuleFor(v => v.HasDiscountApplied,false)
                .RuleFor(v => v.Published,true)
                //Why this property exists?
                .RuleFor(v => v.Status,"Good")
                .RuleFor(v => v.NotReturnable,f => f.booleanValue)
                .RuleFor(v => v.ProductCost,f => f.Money)                
                .RuleFor(v => v.AvailableForPreorder,f => f.booleanValue)
                .RuleFor(v => v.CreatedAt,f => f.Date.Past())
                .RuleFor(v => v.UpdatedOnUtc,f => f.Date.Beetween())
                .RuleFor(v => v.PreOrderAvailabilityStartDate,f => f.Date.Future());
            var listOfProducts = fakeProduct.Generate(50);
            return listOfProducts;
        }        
        // public static            
    }
}