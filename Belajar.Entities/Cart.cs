namespace Belajar.Entities
{
    public class Cart
    {
        public string Id { get; set; } = string.Empty;
        public string ProductId { set; get; } = string.Empty;
        public Product Product { get; set; } = null!;
        public string AccountId { get; set;} = string.Empty;
        public Account Account { get; set; } = null!;

        public int Quantity { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}