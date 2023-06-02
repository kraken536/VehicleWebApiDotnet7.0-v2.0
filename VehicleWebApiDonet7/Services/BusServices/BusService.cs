using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BusServices
{
    public class BusService : IBusService
    {
        private static List<Bus> Buses = new List<Bus>()
        {
            new Bus
            {
                Id = 1,
                Color = "White",
                Model = "Fuel Cell Bus",
                Year = 2022,
                BusHeightInMeter = 5,
            },
            new Bus
            {
                Id = 2,
                Color = "Yellow",
                Model = "OniBus Marco Polo",
                Year = 2014,
                BusHeightInMeter = 7,
            },
            new Bus
            {
                Id = 3,
                Color = "Red",
                Model = "Londonian Buses",
                Year = 2018,
                BusHeightInMeter = 11,
            },
            new Bus
            {
                Id = 4,
                Color = "Yellow",
                Model = "Cobus",
                Year = 2020,
                BusHeightInMeter = 5,
            },
        };

        public Bus? DeleteBus(int id)
        {
            var result = Buses.Find(x => x.Id == id);

            if (result == null)
                return null;

            Buses.Remove(result);

            return result;
        }

        public List<Bus>? GetBusByColor(string color)
        {
            var result = new List<Bus>();

            foreach (Bus bus in Buses)
            {
                if (bus.Color.ToLower() == color.ToLower())
                {
                    result.Add(bus);
                }
            }

            if (result.Count == 0)
            {
                return null;
            }

            return result;
        }

        public List<Bus>? GetBusList()
        {
            if(Buses.Count == 0) 
                return null;

            return Buses;
        }
    }
}
