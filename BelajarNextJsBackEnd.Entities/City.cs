namespace BelajarNextJsBackEnd.Entities
{
    public class City
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public List<ShippingInformation> ShippingInformations { set; get; } = new List<ShippingInformation>();

        public string ProvinceId { set; get; } = "";

        public Province Province { set; get; } = null!;

        public DateTimeOffset CreatedAt { set; get; }
    }
}