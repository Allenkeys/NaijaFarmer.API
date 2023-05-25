using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NaijaFarmer.Models.Entities;

namespace NaijaFarmer.DATA.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasMany(r => r.UserRoles)
                .WithOne(r => r.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            builder.HasMany(r => r.RoleClaims)
                .WithOne(r => r.Role)
                .HasForeignKey(rc => rc.RoleId)
                .IsRequired();
        }
    }
}
