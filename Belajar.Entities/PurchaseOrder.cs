namespace Belajar.Entities
{
    public class PurchaseOrder
    {
        public string AccountId { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;
        public string Id { get; set; } = string.Empty;
        public string ShippingInformationId { get; set;} = string.Empty;
        public ShippingInformation ShippingInformation { get; set; } = null!;
        public string PurchaseOrderStatusId { set; get; } = string.Empty;
        public PurchaseOrderStatus PruchaseOrderStatus { get; set; } = null!;
        public List<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = new List<PurchaseOrderDetail>();
        public DateTimeOffset CreatedAt { get; set; }

    }
}