using ShopOnline.Domain.Entities;

namespace ShopOnline.Domain.Entities
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}
