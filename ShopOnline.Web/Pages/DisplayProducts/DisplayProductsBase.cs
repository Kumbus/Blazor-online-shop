using Microsoft.AspNetCore.Components;
using ShopOnline.Application.DTOs.ProductDTOs;

namespace ShopOnline.Web.Pages.DisplayProducts
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
