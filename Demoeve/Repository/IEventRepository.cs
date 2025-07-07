using DemoEvent.Models;

namespace DemoEvent.Repository
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
    }
}
