using Microsoft.AspNetCore.Identity;

namespace KonsumimiProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
    }
}
