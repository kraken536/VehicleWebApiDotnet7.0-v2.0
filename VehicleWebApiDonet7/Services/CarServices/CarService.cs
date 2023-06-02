using Microsoft.AspNetCore.Mvc;
using VehicleWebApiDonet7.Models;

namespace VehicleWebApiDonet7.Services.CarServices
{
    public class CarService : ICarService
    {

        private static List<Car> Cars = new List<Car>()
        {
            new Car
            {
                Id = 1,
                Color = "Blue",
                Model = "Toyota Rav4",
                Year = 2022,
                Wheels = 3,
                Headlights = "On",
            },
            new Car
            {
                Id = 2,
                Color = "Red",
                Model = "Toyota Camry",
                Year = 2012,
                Wheels = 4,
                Headlights = "Off",
            },
            new Car
            {
                Id = 3,
                Color = "Blue",
                Model = "Mercedes Benz",
                Year = 2022,
                Wheels = 5,
                Headlights = "On",
            },
            new Car
            {
                Id = 4,
                Color = "Green",
                Model = "Maseratti",
                Year = 2021,
                Wheels = 2,
                Headlights = "On",
            },
        };

        public List<Car>? GetCarByColor(string color)
        {
            var result = new List<Car>();

            foreach (Car car in Cars)
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

        public Car? CarHeadlightsById(int id)
        {
            var result = Cars.Find(x => x.Id == id);

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

            return result;
        }

        public Car? DeleteCar(int id)
        {
            var result = Cars.Find(x => x.Id == id);

            if (result == null)
                return null;

            Cars.Remove(result);

            return result;
        }

        public List<Car>? GetAllCars()
        {
            if(Cars.Count == 0)
                return null;

            return Cars;
        }

        public Car? GetCarById(int id)
        {
            var result = Cars.Find(Car => Car.Id == id);
            
            if(result == null)
            {
                return null;
            }

            return result;
        }

        public List<Car>? AddNewCar(Car car)
        {
            if (car == null)
                return null;

            Cars.Add(car);

            return Cars;
        }
    }
}
