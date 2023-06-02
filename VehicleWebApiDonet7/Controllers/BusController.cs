using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleWebApiDonet7.Models;
using VehicleWebApiDonet7.Services.BusServices;

namespace VehicleWebApiDonet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("{color}")]
        public ActionResult<List<Car>> GetBusByColor(string color)
        {

            var result = _busService.GetBusByColor(color);

            if (result == null)
            {
                return NotFound("There is no bus available with the given color");
            }

            return Ok(result);
        }

        [HttpDelete("delete/{id:int?}")]
        public ActionResult<Bus> DeleteBus(int id)
        {
            var result = _busService.DeleteBus(id);
            if (result == null)
            {
                return NotFound("There is no bus available with the given ID...");
            }

            return Ok(result);
        }

        [HttpGet]
        public ActionResult<List<Bus>> GetBusList()
        {
            var result = _busService.GetBusList();
            if (result == null)
            {
                return NotFound("The bus list is empty for the moment...");
            }

            return result;
        }
    }
}
