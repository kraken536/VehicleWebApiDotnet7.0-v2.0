using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BusServices
{
    public interface IBusService
    {
        List<Bus>? GetBusList();

        List<Bus>? GetBusByColor(string color);

        Bus? DeleteBus(int id); 
    }
}
