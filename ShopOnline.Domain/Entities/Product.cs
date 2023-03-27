using ShopOnline.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public ProductCategory ProductCategory { get; set; }
        public IEnumerable<CartItem> CartItems { get; set; }

    }
}
