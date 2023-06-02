using Microsoft.AspNetCore.Mvc;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.CarServices
{
    public interface ICarService
    {
        Task<List<Car>?> GetAllCars();

        Task<List<Car>?> GetCarByColor(string color);

        Task<List<Car>?> AddNewCar(Car car);

        Task<Car?> GetCarById(int id);

        Task<Car?> CarHeadlightsById(int id);

        Task<Car?> DeleteCar(int id);

    }
}
