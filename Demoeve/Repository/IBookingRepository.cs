using DemoEvent.Models;

namespace DemoEvent.Repository
{
    public interface IBookingRepository
    {
        Task AddBookingAsync(Booking booking);
    }
}
