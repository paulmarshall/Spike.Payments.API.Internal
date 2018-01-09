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
        private readonly PaymentEventContext _context;

        public EventsController(PaymentEventContext context)
        {
            _context = context;
        }      

        // GET api/values
        [HttpGet]
        public IEnumerable<PaymentEvent> Get()
        {
            return this._context.PaymentEvents.ToList();
        }

        [HttpGet("{id}", Name = "GetEvent")]
        public IActionResult GetById(long id)
        {
            var item = _context.PaymentEvents.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }        

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]PaymentEvent item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.PaymentEvents.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetEvent", new { id = item.Id }, item);            
        }
    }
}