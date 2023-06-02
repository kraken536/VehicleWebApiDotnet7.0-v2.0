namespace VehicleWebApiDonet7.Models
{
    public class Car : Vehicle
    {
        public int Wheels { get; set; }

        public string Headlights { get; set; } = string.Empty;
    }

}
