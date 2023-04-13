namespace Belajar.Entities
{
    public class ShippingInformation
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;
        public string CityId { get; set;} = string.Empty;
        public City City { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}