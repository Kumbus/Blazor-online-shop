using ShopOnline.Application.DTOs.ProductDTOs;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class BlazorProductsService : IBlazorProductsService
    {
        private readonly HttpClient _httpClient;
        public BlazorProductsService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task<ProductDto> GetProduct(Guid productId)
        {
            try
            {
                var product = await _httpClient.GetFromJsonAsync<ProductDto>($"api/products/{productId}");
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/products");
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
