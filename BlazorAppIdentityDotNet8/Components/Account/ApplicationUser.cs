using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.AspNetCore.Routing
{
    internal class ApplicationUser : IdentityUser
    {
        [Phone]
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }

        public DateOnly? DateOfBirth { get; set; }
    }
}