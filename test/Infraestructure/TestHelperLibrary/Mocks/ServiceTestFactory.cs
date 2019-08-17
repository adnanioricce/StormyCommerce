namespace TestHelperLibrary.Mocks
{
    public static class ServiceTestFactory
    {
        public static ProductService GetProductService()
        {            
            return new ProductService(RepositoryHelper.GetRepository<StormyProduct>());            
        }
        public static CategoryService GetCategoryService()
        {
            return new GetCategoryService(RepositoryHelper.GetRepository<Category>());
        }
    }
}