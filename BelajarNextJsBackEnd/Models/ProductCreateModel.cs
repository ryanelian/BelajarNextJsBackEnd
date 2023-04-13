using BelajarNextJsBackEnd.Entities;

namespace BelajarNextJsBackEnd.Models
{
    public class ProductCreateModel
    {
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandId { set; get; } = "";

    }

    public class ProductDetailModel
    {
        public string Id { get; set; } = "";

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandId { set; get; } = "";

        public string BrandName { get; set; } = "";

    }
}