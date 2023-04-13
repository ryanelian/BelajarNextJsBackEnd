namespace Belajar.Entities
{
    public class Brand
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
        public DateTimeOffset CreatedAt { get; set; }

    }
}