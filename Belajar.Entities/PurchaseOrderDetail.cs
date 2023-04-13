namespace Belajar.Entities
{
    public class PurchaseOrderDetail
    {
        public string Id { get; set; } = string.Empty;
        public string ProductId { set; get; } = string.Empty;
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
        public string PurchaseOrderId { get; set; } = string.Empty;
        public PurchaseOrder PurchaseOrder { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}