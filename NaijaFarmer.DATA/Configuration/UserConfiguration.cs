using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NaijaFarmer.Models.Entities;

namespace NaijaFarmer.DATA.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasMany(u => u.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            builder.HasMany(u => u.Claims)
                .WithOne(u => u.User)
                .HasForeignKey(uc => uc.UserId)
                .IsRequired();

            builder.HasMany(u => u.Token)
                .WithOne()
                .HasForeignKey(ut => ut.UserId)
                .IsRequired();

            builder.HasMany(u => u.Login)
               .WithOne()
               .HasForeignKey(ul => ul.UserId)
               .IsRequired();
        }
    }
}
