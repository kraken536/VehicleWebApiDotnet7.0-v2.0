using Microsoft.AspNetCore.Mvc;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.CarServices
{
    public interface ICarService
    {
        List<Car>? GetAllCars();

        List<Car>? GetCarByColor(string color);

        List<Car>? AddNewCar(Car car);

        Car? GetCarById(int id);

        Car? CarHeadlightsById(int id);

        Car? DeleteCar(int id);

    }
}
