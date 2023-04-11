namespace BelajarNextJsBackEnd.Entities
{
    public class Province
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public List<City> Cities { set; get; } = new List<City>();

        public DateTimeOffset CreatedAt { set; get; }
    }
}