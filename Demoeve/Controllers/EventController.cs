using DemoEvent.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _repo;
        public EventController(IEventRepository repo) => _repo = repo;

        [HttpGet]
        [Route("getEvent")]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _repo.GetAllEventsAsync();
            return Ok(events);
        }
    }

}
