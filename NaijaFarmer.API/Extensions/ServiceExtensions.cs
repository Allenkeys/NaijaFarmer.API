using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NaijaFarmer.DATA.DataContext;
using NaijaFarmer.Models.Entities;

namespace NaijaFarmer.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDbConnection(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(opts =>
                opts.UseSqlServer(config.GetConnectionString("DefaultConn")));
        }

        public static void AddCustomIdentity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}
