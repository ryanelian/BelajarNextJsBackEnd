namespace Belajar.Entities
{
    public class Province
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<City> Cities { get; set; } = new List<City>();
        public DateTimeOffset CreatedAt { get; set; }
    }
}