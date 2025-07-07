namespace DemoEvent.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public bool IsOnlinePayment { get; set; }
        public string? ProofDocumentPath { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
