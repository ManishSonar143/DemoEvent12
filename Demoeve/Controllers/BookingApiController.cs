using DemoEvent.Models;
using DemoEvent.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingApiController : ControllerBase
    {
        private readonly IBookingRepository _repo;
        private readonly IWebHostEnvironment _env;

        public BookingApiController(IBookingRepository repo, IWebHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromForm] Booking model, IFormFile? proof)
        {
            if (model.IsOnlinePayment && proof != null)
            {
                string folderPath = Path.Combine(_env.WebRootPath, "uploads");
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, Path.GetFileName(proof.FileName));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await proof.CopyToAsync(stream);
                }
                model.ProofDocumentPath = "/uploads/" + proof.FileName;
            }

            model.BookingDate = DateTime.Now;
            await _repo.AddBookingAsync(model);
            return Ok(new { message = "Booking successful" });
        }
    }

}
