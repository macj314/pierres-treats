using Microsoft.AspNetCore.Identity;

namespace PierresTreats.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}