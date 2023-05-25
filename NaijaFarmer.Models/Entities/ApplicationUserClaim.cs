using Microsoft.AspNetCore.Identity;

namespace NaijaFarmer.Models.Entities
{
    public class ApplicationUserClaim : IdentityUserClaim<string>
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public ApplicationUser User { get; set; }
    }
}