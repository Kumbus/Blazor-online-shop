using ShopOnline.Application.DTOs.ProductDTOs;
using ShopOnline.Domain.Entities;


namespace ShopOnline.Application.ServiceInterfaces
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProduct(Guid productId);
        Task<ProductCategory> GetCategory(Guid categoryId);
    }
}
