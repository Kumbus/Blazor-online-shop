namespace ShopOnline.Domain.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public IEnumerable<CartItem> CartItems { get; set;}
        public User User { get; set; }
    }
}
