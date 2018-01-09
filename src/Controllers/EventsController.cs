using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Internal.Models;

namespace API.Internal.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly CustomerEventContext _context;

        public EventsController(CustomerEventContext context)
        {
            _context = context;
        }      

        // GET api/values
        [HttpGet]
        public IEnumerable<CustomerEvent> Get()
        {
            return this._context.CustomerEvents.ToList();
        }

        [HttpGet("{id}", Name = "GetEvent")]
        public IActionResult GetById(long id)
        {
            var item = _context.CustomerEvents.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }        

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CustomerEvent item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.CustomerEvents.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetEvent", new { id = item.Id }, item);            
        }
    }
}