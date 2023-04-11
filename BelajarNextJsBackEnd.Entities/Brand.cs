namespace BelajarNextJsBackEnd.Entities
{
    public class Brand
    {
        public string Id { set; get; } = "";

        public string Name { get; set; } = "";

        public List<Product> Products { get; set; } = new List<Product>();

        public DateTimeOffset CreatedAt { set; get; }
    }
}