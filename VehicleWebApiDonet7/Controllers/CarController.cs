using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleWebApiDonet7.Models;
using VehicleWebApiDonet7.Services.CarServices;

namespace VehicleWebApiDonet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetAllCars()
        {
            var result = await _carService.GetAllCars();

            if(result is null)
            {
                return NotFound("There is no car for the moment...");
            }

            return result;
        }

        [HttpGet("{id:int?}")]
        public async Task<ActionResult<Car>> GetCarById(int id)
        {
            var result = await _carService.GetCarById(id);

            if (result is null)
                return NotFound("No car available with the given ID...");

            return result;
        }


        [HttpGet("{color}")]
        public async Task<ActionResult<List<Car>>> GetCarsByColor(string color)
        {
            
            var result = await _carService.GetCarByColor(color);

            if (result == null)
            {
                return NotFound("There is no car available with the given color");
            }

            return Ok(result);
        }

        [HttpPost("headlight/{id:int?}")]
        public async Task<ActionResult<Car>> OnOffCarHeadlightsById(int id)
        {
            var result = await _carService.CarHeadlightsById(id);

            if (result == null)
                return NotFound("There is no car with the given ID...");

            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<ActionResult<List<Car>>> AddNewCar(Car car)
        {
            var result  = await _carService.AddNewCar(car);

            if (result == null)
                return NotFound("Invalid Data Inserted Try again...");

            return Ok(result);
        }

        [HttpDelete("delete/{id:int?}")]
        public async Task<ActionResult<Car>> DeleteCarById(int id)
        {
            var result = await _carService.DeleteCar(id);

            if(result == null)
            {
                return NotFound("There is no car with the given ID...");
            }

            return Ok(result);
        }
    }
}
