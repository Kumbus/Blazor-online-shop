using AutoMapper;
using ShopOnline.Application.DTOs.ProductDTOs;
using ShopOnline.Application.ServiceInterfaces;
using ShopOnline.Domain.Entities;
using ShopOnline.Domain.RepositoryInterfaces;

namespace ShopOnline.Application.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public ProductsService(IProductsRepository productsRepository, IMapper mapper)
        {
            _productsRepository = productsRepository;
            _mapper = mapper;
        }

        public async Task<ProductCategory> GetCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetProduct(Guid productId)
        {
            var product = await _productsRepository.GetProduct(productId);
            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var products = await _productsRepository.GetProducts();

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);

            return productsDto;
        }
    }
}
