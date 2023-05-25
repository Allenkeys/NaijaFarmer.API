using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NaijaFarmer.DATA.Configuration;
using NaijaFarmer.Models.Entities;

namespace NaijaFarmer.DATA.DataContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, 
        ApplicationUserClaim, ApplicationUserRole, IdentityUserLogin<string>, ApplicationRoleClaim, 
        IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
