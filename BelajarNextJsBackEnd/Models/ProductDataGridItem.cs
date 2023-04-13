namespace BelajarNextJsBackEnd.Models
{
    public class ProductDataGridItem
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandName { set; get; } = "";

        public DateTimeOffset CreatedAt { set; get; }
    }
}
