using Microsoft.EntityFrameworkCore;
using VehicleWebApiDonet7.Data;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.BoatServices
{
    public class BoatService : IBoatService
    {
        private readonly DataContext _context;
        public BoatService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Boat>?> AddNewBoat(Boat boat)
        {
            if (boat is null)
                return null;

            _context.Boats.Add(boat);
            await _context.SaveChangesAsync(); 

            return await _context.Boats.ToListAsync();
        }

        public async Task<List<Boat>?> GetBoatList()
        {
            var temp = await _context.Boats.ToListAsync();
            if(temp.Count == 0)
                return null;

            return temp;
        }

        public async Task<List<Boat>?> GetBoatsByColor(string color)
        {
            var result = new List<Boat>();
            var temp = await _context.Boats.ToListAsync();

            foreach (Boat boat in temp)
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
