namespace BelajarNextJsBackEnd.Models.Product
{
    public class ProductCreateModel
    {
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandId { set; get; } = "";
    }

}
