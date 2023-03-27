using ShopOnline.Application.DTOs.ProductDTOs;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IBlazorProductsService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProduct(Guid productId);
    }
}
