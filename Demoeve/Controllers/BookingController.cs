using Microsoft.AspNetCore.Mvc;

namespace DemoEvent.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult booking()
        {
            return View();
        }
    }
}
