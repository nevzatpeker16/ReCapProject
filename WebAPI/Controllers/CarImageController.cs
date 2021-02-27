using Buisness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        ICarImageService _carImageService;

        [HttpGet("getall")]
        public IActionResult GetAllCarImages()
        {
            var result = _carImageService.ListImages();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("addcarımage")]
        public IActionResult AddCarImage([FromForm(Name = ("Image"))] IFormFile formFile, [FromForm] CarImage carImage)
        {
            var result = _carImageService.AddCarImage(formFile,carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpPost("deletecarımage")]
        public IActionResult DeleteCarImage(CarImage carImage)
        {
            var result = _carImageService.DeleteCarImage(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("updatecarımage")]
        public IActionResult UpdateCarImage([FromForm(Name = ("Image"))] IFormFile formFile, [FromForm] CarImage carImage)
        {
            var result = _carImageService.UpdateCarImage(formFile,carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpGet("getcarımagesbycarıd")]
        public IActionResult GetImagesByCarID(int carID)
        {
            var result = _carImageService.ListImagesByCarID(carID);
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
