namespace BelajarNextJsBackEnd.Models
{
    public class BrandCreateModel
    {
        public string Name { get; set; } = "";
    }

    public class AddToCartModel
    {
        public string ProductId { set; get; } = "";

        public int Qty { set; get; }
    }
}
