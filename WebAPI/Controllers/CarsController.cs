using Buisness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet ("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetCars();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("addcar")]
        public IActionResult AddCar(Car car)
        {
            var result = _carService.AddCar(car);
                if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);

            }        
        }
        [HttpGet ("getbyid")]
        public IActionResult GetCarByID(int carID)
        {
            var result = _carService.GetCarsByCarID(carID);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
