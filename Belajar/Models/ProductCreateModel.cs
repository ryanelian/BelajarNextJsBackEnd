namespace Belajar.Models
{
    public class ProductCreateModel
    {
        public string Name { get; set; } = "";
        public string BrandId { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public string Description { get; set; } = "";

    }
    public class ProductDetailModel
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string BrandId { get; set; } = "";
        public string BrandName { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; } 
        public string Description { get; set; } = "";
    }
}
