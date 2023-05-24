using Microsoft.AspNetCore.Identity;

namespace NaijaFarmer.Models.Entities
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public ApplicationRole Role { get; set; }
    }
}