using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack.Models;
using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        private readonly BurgerRepository _br; //provides refrence to repository (service)
        public BurgersController(BurgerRepository br)
        {
            _br = br;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Burger>> Get()
        {
            try
            {
                return Ok(_br.GetAllBurgers());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Burger> Get(int id)
        {
            try
            {
                return Ok(_br.GetBurgerById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        // POST api/values
        [HttpPost]
        public ActionResult<IEnumerable<Burger>> Post([FromBody] Burger value)
        {
            try
            {
                return Ok(_br.CreateBurger(value));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Burger> Put(int id, [FromBody] Burger value)
        {
            try
            {
                value.Id = id;
                return Ok(_br.UpdateBurger(value));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            try
            {
                return Ok(_br.DeleteBurger(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
