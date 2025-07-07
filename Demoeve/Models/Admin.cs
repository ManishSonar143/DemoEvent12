using Microsoft.AspNetCore.Identity;

namespace DemoEvent.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
