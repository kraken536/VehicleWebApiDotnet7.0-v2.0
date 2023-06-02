using Microsoft.EntityFrameworkCore;
using VehicleWebApiDonet7.Data;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BusServices
{
    public class BusService : IBusService
    {
        private readonly DataContext _context;

        public BusService(DataContext context)
        {
            _context = context;
        }

        public async Task<Bus?> DeleteBus(int id)
        {
            var result = await _context.Buses.FindAsync(id);

            if (result is null)
                return null;

            _context.Buses.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<List<Bus>?> GetBusByColor(string color)
        {
            var result = new List<Bus>();
            var temp = await _context.Buses.ToListAsync();

            foreach (Bus bus in temp)
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

        public async Task<List<Bus>?> GetBusList()
        {
            var temp = await _context.Buses.ToListAsync();
            if(temp.Count == 0) 
                return null;

            return temp;
        }
    }
}
