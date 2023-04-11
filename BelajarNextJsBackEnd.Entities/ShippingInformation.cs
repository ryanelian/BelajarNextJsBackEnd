namespace BelajarNextJsBackEnd.Entities
{
    public class ShippingInformation
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string PhoneNumber { set; get; } = "";

        public string Address { set; get; } = "";

        public string AccountId { set; get; } = "";

        public Account Account { set; get; } = null!;

        public string CityId { set; get; } = "";

        public City City { set; get; } = null!;

        public DateTimeOffset CreatedAt { set; get; }
    }
}