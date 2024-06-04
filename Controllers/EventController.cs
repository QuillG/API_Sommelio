using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sommelio.Data;
using Sommelio.DTO;
using Sommelio.Entities;
using Sommelio.Services;

namespace Sommelio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly DataContext _context;
        private readonly EventsService _eventService;

        public EventController(DataContext context, EventsService eventsService)
        {
            _context = context;
            _eventService = eventsService;
        }

        [HttpGet("ResumeEvents")]
        public async Task<ActionResult<List<ResumeEventDto>>> GetResumeEvents()
        {
            var events = await _eventService.GetResumeEventsAsync();
            return Ok(events);
        }

        [HttpGet]
        public async Task<ActionResult> GetEvents()
        {
            var events = await _context.Events.ToListAsync();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetEvent(int id)
        {
            var events = await _context.Events.FirstOrDefaultAsync(e => e.Id == id);
            return Ok(events);
        }

        [HttpPost]
        public async Task<ActionResult> AddEvent([FromBody] EventDto eventToAdd)
        {
            var newEvent = await _eventService.PostEventAsync(eventToAdd);
            return Ok(newEvent);
        }



    }
}
