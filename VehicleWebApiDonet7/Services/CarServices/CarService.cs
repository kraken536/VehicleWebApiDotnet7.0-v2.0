using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleWebApiDonet7.Data;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.CarServices
{
    public class CarService : ICarService
    {

        private readonly DataContext _context;
        public CarService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Car>?> GetCarByColor(string color)
        {
            var result = new List<Car>();

            var temp = await _context.Cars.ToListAsync(); 

            foreach (Car car in temp)
            {
                if (car.Color.ToLower() == color.ToLower())
                {
                    result.Add(car);
                }
            }

            if(result.Count == 0)
            {
                return null;
            }

            return result;
        }

        public async Task<Car?> CarHeadlightsById(int id)
        {
            var result = await _context.Cars.FindAsync(id);

            if (result == null)
                return null;

            if (result.Headlights.Contains("On"))
            {
                result.Headlights = "Off";
            }
            else
            {
                result.Headlights = "On";
            }
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<Car?> DeleteCar(int id)
        {
            var result = await _context.Cars.FindAsync(id);

            if (result is null)
                return null;

            _context.Cars.Remove(result);
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<List<Car>?> GetAllCars()
        {
            var result = await _context.Cars.ToListAsync();
            if(result is null)
                return null;

            return result;
        }

        public async Task<Car?> GetCarById(int id)
        {
            var result = await _context.Cars.FindAsync(id);
            
            if(result == null)
            {
                return null;
            }

            return result;
        }

        public async Task<List<Car>?> AddNewCar(Car car)
        {
            if (car is null)
                return null;

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return await _context.Cars.ToListAsync();
        }
    }
}
