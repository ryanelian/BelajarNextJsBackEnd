namespace Belajar.Entities
{
    public class City
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<ShippingInformation> ShippingInformations { get; set; } = new List<ShippingInformation>();
        public string ProvinceId { get; set; } = string.Empty;
        public Province Province { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}