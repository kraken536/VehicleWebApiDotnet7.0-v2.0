namespace VehicleWebApiDonet7.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Color { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public int Year { get; set; }
    }
}
