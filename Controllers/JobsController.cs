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
    // The [controller] names the route with whatever the name before the word "Controller" in the Class is:  <-- "api/jobs"
    public class JobsController : ControllerBase
    {
        private readonly JobsService _service;

        public JobsController(JobsService service)
        // Dependency Injection:  In order to use this Controller, this Service must be injected on Construction
        {
            _service = service;
        }

        [HttpGet]
        // This attribute defines that the method to follow is a "get" request
        public ActionResult<IEnumerable<Job>> getAll()
        // IEnumerable takes the place of any collection type (List, Array, etc...)
        // ActionResult <-- "of type" List <-- "of type" Job
        {
            try
            {
                return Ok(FakeDB.Jobs);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GetById  <-- same as :id
        [HttpGet("{id}")]
        public ActionResult<Job> GetById(string id)
        {
            try
            {
                Job found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST
        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        // This says that "From the Body" create a Job called "newJob"
        {
            try
            {
                Job job = _service.Create(newJob);
                return Ok(job);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST
        [HttpPut("{id}")]
        public ActionResult<Job> Edit([FromBody] Job editJob, string id)
        {
            try
            {
                editJob.Id = id;
                Job edit = _service.Edit(editJob);
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
                _service.DeleteJob(id);
                return Ok("Deleted!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}