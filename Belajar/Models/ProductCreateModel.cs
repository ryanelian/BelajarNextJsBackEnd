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
}
