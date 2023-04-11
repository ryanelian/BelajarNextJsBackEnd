namespace BelajarNextJsBackEnd.Entities
{
    public class Cart
    {
        public string Id { set; get; } = "";

        public string ProductId { set; get; } = "";

        public Product Product { set; get; } = null!;

        public string AccountId { set; get; } = "";

        public Account Account { set; get; } = null!;

        public int Quantity { set; get; }

        public DateTimeOffset CreatedAt { set; get; }
    }
}