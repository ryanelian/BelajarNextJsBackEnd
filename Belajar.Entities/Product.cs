namespace Belajar.Entities
{
    public class Product
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string BrandId { get; set; } = string.Empty;
        public Brand Brand { get; set; } = null!;
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public DateTimeOffset CreatedAt { get; set; }

    }
}