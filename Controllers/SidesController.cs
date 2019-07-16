using System;
using System.Collections.Generic;
using burgershack.Models;
using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
    //api/sides
    [Route("api/[controller]")]
    [ApiController]
    public class SidesController : ControllerBase
    {
        private readonly SideRepository _repo; //provides refrence to repository (service)
        public SidesController(SideRepository repo)
        {
            _repo = repo;
        }
        // GET api/sides
        [HttpGet]
        public ActionResult<IEnumerable<Side>> Get()
        {
            try
            {
                return Ok(_repo.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET api/sides/5
        [HttpGet("{id}")]
        public ActionResult<Side> Get(int id)
        {
            try
            {
                return Ok(_repo.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        // POST api/sides
        [HttpPost]
        public ActionResult<IEnumerable<Side>> Post([FromBody] Side value)
        {
            try
            {
                return Ok(_repo.Create(value));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // PUT api/sides/5
        [HttpPut("{id}")]
        public ActionResult<Side> Put(int id, [FromBody] Side value)
        {
            try
            {
                value.Id = id;
                return Ok(_repo.Update(value));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // DELETE api/sides/5
        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            try
            {
                return Ok(_repo.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
