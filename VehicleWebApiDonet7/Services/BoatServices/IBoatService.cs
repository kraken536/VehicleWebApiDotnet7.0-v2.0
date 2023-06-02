using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BoatServices
{
    public interface IBoatService
    {
        List<Boat>? GetBoatsByColor(string color);

        List<Boat>? GetBoatList();

        List<Boat>? AddNewBoat(Boat boat);
    }
}
