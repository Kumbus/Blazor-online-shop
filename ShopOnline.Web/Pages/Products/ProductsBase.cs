using Microsoft.AspNetCore.Components;
using ShopOnline.Application.DTOs.ProductDTOs;
using ShopOnline.Web.Services.Contracts;


namespace ShopOnline.Web.Pages.Products
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IBlazorProductsService ProductsService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductsService.GetProducts();
        }

        protected IOrderedEnumerable<IGrouping<Guid, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }
        protected string GetCategoryName(IGrouping<Guid, ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
        }
    }
}
