namespace BelajarNextJsBackEnd.Entities
{
    public class Account
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string Email { set; get; } = "";

        public string Password { set; get; } = "";

        public List<Cart> Carts { get; set; } = new List<Cart>();

        public List<ShippingInformation> ShippingInformations { set; get; } = new List<ShippingInformation>();

        public List<PurchaseOrder> PurchaseOrders { set; get; } = new List<PurchaseOrder>();

        public DateTimeOffset CreatedAt { set; get; }
    }
}