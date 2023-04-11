namespace BelajarNextJsBackEnd.Entities
{
    public class PurchaseOrderStatus
    {
        public string Id { set; get; } = "";

        // dipesan
        // dibayar
        // dikonfirmasi
        // dikirim
        // selesai
        // dikomplain

        public List<PurchaseOrder> PurchaseOrders { set; get; } = new List<PurchaseOrder>();

        public DateTimeOffset CreatedAt { set; get; }
    }
}