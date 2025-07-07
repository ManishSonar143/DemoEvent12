using DemoEvent.Data;
using DemoEvent.Models;

namespace DemoEvent.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;
        public BookingRepository(AppDbContext context) => _context = context;

        public async Task AddBookingAsync(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
        }
    }

}
