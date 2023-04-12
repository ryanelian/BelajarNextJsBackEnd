namespace BelajarNextJsBackEnd.Models.City
{
    public class CityDataGridItem
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string ProvinceName { set; get; } = "";

        public DateTimeOffset CreatedAt { set; get; }
    }
}
