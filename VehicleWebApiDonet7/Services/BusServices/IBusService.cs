using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BusServices
{
    public interface IBusService
    {
        Task<List<Bus>?> GetBusList();

        Task<List<Bus>?> GetBusByColor(string color);

        Task<Bus?> DeleteBus(int id);
    }
}
