using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Parkinglot.Application.Model.Vehicle;
using Parkinglot.Domain.Interface;

namespace Parkinglot.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/cars")]
    public class CarsController : Controller
    {

        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarsController(ICarRepository carRepository, IMapper mapper)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            var cars = _carRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<CarModel>>(cars));
        }

        [HttpGet("{id}")]
        public IActionResult GetCar([FromRoute]int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = _carRepository.GetById(id);

            if (car == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CarModel>(car));
        }

        public IActionResult UpdateCar([FromBody] CarModel carModel)
        {
            if()
        }
    }
}