namespace Belajar.Entities
{
    public class PurchaseOrderStatus
    {
        public string Id { get; set; } = string.Empty;
        public List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
        public DateTimeOffset CreatedAt { get; set; }
    }
}