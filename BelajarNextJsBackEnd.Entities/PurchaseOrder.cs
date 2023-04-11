namespace BelajarNextJsBackEnd.Entities
{
    public class PurchaseOrder
    {
        public string Id { set; get; } = "";

        public string AccountId { set; get; } = "";

        public Account Account { set; get; } = null!;

        public string ShippingInformationId { set; get; } = "";

        public ShippingInformation ShippingInformation { set; get; } = null!;

        public string PurchaseOrderStatusId { set; get; } = "";

        public PurchaseOrderStatus PurchaseOrderStatus { set; get; } = null!;

        public List<PurchaseOrderDetail> PurchaseOrderDetails { set; get; } = new List<PurchaseOrderDetail>();

        public DateTimeOffset CreatedAt { set; get; }
    }
}