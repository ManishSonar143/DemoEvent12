using DemoEvent.Data;
using DemoEvent.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEvent.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;
        public EventRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }
    }

}
