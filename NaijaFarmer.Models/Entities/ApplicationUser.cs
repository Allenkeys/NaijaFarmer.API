using Microsoft.AspNetCore.Identity;
using NaijaFarmer.Models.Enums;

namespace NaijaFarmer.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType UserType { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Token { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Login { get; set; }
        public virtual ICollection<ApplicationUserClaim> Claims { get; set; }
    }
}
