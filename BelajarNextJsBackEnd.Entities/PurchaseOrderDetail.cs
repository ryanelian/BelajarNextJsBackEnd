namespace BelajarNextJsBackEnd.Entities
{
    public class PurchaseOrderDetail
    {
        public string Id { set; get; } = null!;

        public string ProductId { set; get; } = null!;

        public Product Product { set; get; } = null!;

        public int Quantity { set; get; }   

        public string PurchaseOrderId { set; get; } = null!;

        public PurchaseOrder PurchaseOrder { set; get; } = null!;

        public DateTimeOffset CreatedAt { set; get; }
    }
}