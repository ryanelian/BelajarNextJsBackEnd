namespace BelajarNextJsBackEnd.Entities
{
    public class Product
    {
        public string Id { get; set; } = "";

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandId { set; get; } = "";

        public Brand Brand { get; set; } = null!;

        public List<Cart> Carts { get; set; } = new List<Cart>();

        public DateTimeOffset CreatedAt { set; get; }
    }
}