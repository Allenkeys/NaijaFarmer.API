using Microsoft.AspNetCore.Identity;

namespace NaijaFarmer.Models.Entities
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
    }
}