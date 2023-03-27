using Microsoft.EntityFrameworkCore;
using ShopOnline.Domain.Entities;
using ShopOnline.Domain.RepositoryInterfaces;
using ShopOnline.Infrastructure.Data;

namespace ShopOnline.Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DatabaseContext _databaseContext;
        
        public ProductsRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<ProductCategory> GetCategory(Guid categoryId)
        {
            var category = await _databaseContext.ProductCategories.FirstOrDefaultAsync(c => c.Id == categoryId);
            return category;
        }

        public async Task<Product> GetProduct(Guid productId)
        {
            var product = await _databaseContext.Products.Include(p => p.ProductCategory).FirstOrDefaultAsync(p => p.Id == productId);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _databaseContext.Products.Include(p => p.ProductCategory).ToListAsync();
            return products;
        }
    }
}
