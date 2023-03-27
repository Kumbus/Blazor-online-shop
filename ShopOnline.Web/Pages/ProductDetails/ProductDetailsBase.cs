using Microsoft.AspNetCore.Components;
using ShopOnline.Application.DTOs.ProductDTOs;
using ShopOnline.Web.Services.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace ShopOnline.Web.Pages.ProductDetails
{
    public class ProductDetailsBase:ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IBlazorProductsService ProductsService { get; set; }
        public ProductDto Product { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
           try
           {
                Product = await ProductsService.GetProduct(new Guid(Id));     
           }
           catch(Exception)
           {
                throw new Exception(ErrorMessage);
           }
        }
    }
}
