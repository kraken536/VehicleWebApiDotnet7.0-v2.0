using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BoatServices
{
    public interface IBoatService
    {
        Task<List<Boat>?> GetBoatsByColor(string color);

        Task<List<Boat>?> GetBoatList();

        Task<List<Boat>?> AddNewBoat(Boat boat);
    }
}
