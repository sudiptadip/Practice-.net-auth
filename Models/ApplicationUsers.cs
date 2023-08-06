using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace auth.Models
{
    public class ApplicationUsers : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        public string? StreetAdderss { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
    }
}
