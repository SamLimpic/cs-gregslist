using System;
using System.Collections.Generic;
using cs_gregslist.DB;
using cs_gregslist.Models;
using cs_gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace cs_gregslist.Controllers
{
    [ApiController]
    // This attribute tells dotnet that this class should be registered with the controllers
    [Route("api/[controller]")]
    // The [controller] names the route with whatever the name before the word "Controller" in the Class is:  <-- "api/cars"
    public class CarsController : ControllerBase
    {
        private readonly CarsService _service;

        public CarsController(CarsService service)
        // Dependency Injection:  In order to use this Controller, this Service must be injected on Construction
        {
            _service = service;
        }

        [HttpGet]
        // This attribute defines that the method to follow is a "get" request
        public ActionResult<IEnumerable<Car>> getAll()
        // IEnumerable takes the place of any collection type (List, Array, etc...)
        // ActionResult <-- "of type" List <-- "of type" Car
        {
            try
            {
                return Ok(FakeDB.Cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GetById  <-- same as :id
        [HttpGet("{id}")]
        public ActionResult<Car> GetById(string id)
        {
            try
            {
                Car found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST
        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car newCar)
        // This says that "From the Body" create a Car called "newCar"
        {
            try
            {
                Car car = _service.Create(newCar);
                return Ok(car);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST
        [HttpPut("{id}")]
        public ActionResult<Car> Edit([FromBody] Car editCar, string id)
        {
            try
            {
                editCar.Id = id;
                Car edit = _service.Edit(editCar);
                return Ok(edit);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            try
            {
                _service.DeleteCar(id);
                return Ok("Deleted!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}