namespace Belajar.Models
{
    public class ProductDataGridItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
    }
}
