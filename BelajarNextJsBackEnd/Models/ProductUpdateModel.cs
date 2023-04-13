namespace BelajarNextJsBackEnd.Models
{
    public class ProductUpdateModel
    {
        public string Name { get; set; } = "";

        public string BrandId { set; get; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

    }
}
