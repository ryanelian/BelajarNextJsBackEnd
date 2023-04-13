namespace Belajar.Entities
{
    public class Account
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<ShippingInformation> ShippingInformations { get; set; } = new List<ShippingInformation>();
        public List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
        public DateTimeOffset CreatedAt { get; set; }
    }
}