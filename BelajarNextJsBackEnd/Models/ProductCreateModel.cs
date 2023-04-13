namespace BelajarNextJsBackEnd.Models
{
    public class ProductCreateModel
    {
        public string Name { get; set; } = "";

        public string BrandId { set; get; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

    }

    public class ProductDetailModel
    {
        public string Id { get; set; } = "";

        public string Name { get; set; } = "";

        public string BrandId { set; get; } = "";

        public string BrandName { set; get; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

    }
}
