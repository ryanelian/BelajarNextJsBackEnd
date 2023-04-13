namespace Belajar.Models
{
    public class CityDataGridItem
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ProvinceName { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
    }
}
