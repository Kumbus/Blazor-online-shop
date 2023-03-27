using ShopOnline.Domain.Entities;


namespace ShopOnline.Domain.RepositoryInterfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(Guid productId);
        Task<ProductCategory> GetCategory(Guid categoryId);
    }
}
