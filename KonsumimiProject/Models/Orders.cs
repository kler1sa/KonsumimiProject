namespace KonsumimiProject.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string? ShipName { get; set; } = string.Empty;
        public string? ShipDesc { get; set; } = string.Empty;
    }
}
