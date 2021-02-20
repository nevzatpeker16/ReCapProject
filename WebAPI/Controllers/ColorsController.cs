using Buisness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : Controller
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
      [HttpGet("getall")]
      public IActionResult GetAll()
        {
            var result = _colorService.GetAllColors();
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }
        }
    [HttpPost("addcolor")]
    public IActionResult AddColor(Color color)
        {
            var result = _colorService.AddColor(color);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    [HttpPost("updatecolor")]
    public IActionResult UpdateColor(Color color)
        {
            var result = _colorService.UpdateColor(color);
          if (result.Success)
            {
                return Ok(result);
            }           
          else
            {
                return BadRequest(result);
            }

        }
    [HttpPost("deletecolor")]
    public IActionResult DeleteColor(Color color)
        {  
            var result = _colorService.DeleteColor(color);
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
