using Business.Abstract;
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
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carımageService;

        public CarImagesController(ICarImageService carımageService)
        {
            _carımageService = carımageService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _carımageService.GetAll();
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _carımageService.GetById(id);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carımageService.Add(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var carImage = _carımageService.GetById(Id).Data;
            var result = _carımageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, CarImage carImage)
        {
            var result = _carımageService.Update(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carımageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carımageService.GetAll();
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
