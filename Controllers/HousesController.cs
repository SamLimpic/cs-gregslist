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
    // The [controller] names the route with whatever the name before the word "Controller" in the Class is:  <-- "api/houses"
    public class HousesController : ControllerBase
    {
        private readonly HousesService _service;

        public HousesController(HousesService service)
        // Dependency Injection:  In order to use this Controller, this Service must be injected on Construction
        {
            _service = service;
        }

        [HttpGet]
        // This attribute defines that the method to follow is a "get" request
        public ActionResult<IEnumerable<House>> getAll()
        // IEnumerable takes the place of any collection type (List, Array, etc...)
        // ActionResult <-- "of type" List <-- "of type" House
        {
            try
            {
                return Ok(FakeDB.Houses);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GetById  <-- same as :id
        [HttpGet("{id}")]
        public ActionResult<House> GetById(string id)
        {
            try
            {
                House found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST
        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        // This says that "From the Body" create a House called "newHouse"
        {
            try
            {
                House house = _service.Create(newHouse);
                return Ok(house);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST
        [HttpPut("{id}")]
        public ActionResult<House> Edit([FromBody] House editHouse, string id)
        {
            try
            {
                editHouse.Id = id;
                House edit = _service.Edit(editHouse);
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
                _service.DeleteHouse(id);
                return Ok("Deleted!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}