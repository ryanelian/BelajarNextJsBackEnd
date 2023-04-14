namespace BelajarNextJsBackEnd.Models
{
    public class ProductDetailModel
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandId { get; set; } = string.Empty;

        public string BrandName { set; get; } = string.Empty;
    }
}
