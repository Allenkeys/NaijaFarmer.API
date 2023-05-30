using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NaijaFarmer.DATA.DataContext;

namespace NaijaFarmer.API.ContextFactory
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builderApp = WebApplication.CreateBuilder();
            var configuration = new SqlConnectionStringBuilder(
                builderApp.Configuration.GetConnectionString("DefaultConn"));

            // Use this method, when the connection string is saved in the appsettings
            /*var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();*/

            //Then in the UseSqlServer method use:
            //configuration.GetConnectionString("DefaultConn")

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(configuration.ConnectionString,
                b => b.MigrationsAssembly("NaijaFarmer.API"));
            return new ApplicationDbContext(builder.Options);
        }
    }
}
