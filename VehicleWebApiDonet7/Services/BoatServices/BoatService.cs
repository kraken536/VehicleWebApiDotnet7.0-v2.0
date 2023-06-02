using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BoatServices
{
    public class BoatService : IBoatService
    {
        private static List<Boat> Boats = new List<Boat>()
        {
            new Boat
            {
                Id = 1,
                Color = "White",
                Model = "Ponton Boats",
                Year = 2018,
                BoatLengthInMeter = 50,
            },
            new Boat
            {
                Id = 2,
                Color = "Black",
                Model = "Premier Marine",
                Year = 2020,
                BoatLengthInMeter = 150,
            },
            new Boat
            {
                Id = 3,
                Color = "Navy",
                Model = "Bennington Marine",
                Year = 2022,
                BoatLengthInMeter = 120,
            },

        };

        public List<Boat>? AddNewBoat(Boat boat)
        {
            if (boat == null)
                return null;

            Boats.Add(boat);

            return Boats;
        }

        public List<Boat>? GetBoatList()
        {
            if(Boats.Count == 0)
                return null;

            return Boats;
        }

        public List<Boat>? GetBoatsByColor(string color)
        {
            var result = new List<Boat>();

            foreach (Boat boat in Boats)
            {
                if (boat.Color.ToLower() == color.ToLower())
                {
                    result.Add(boat);
                }
            }

            if (result.Count == 0)
            {
                return null;
            }

            return result;
        }
    }
}
