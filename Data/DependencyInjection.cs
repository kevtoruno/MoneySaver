using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Core.Interfaces;
using System.Reflection;
using Data.Persistence;

namespace Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            bool useSQLServer = true;

            var assembly = Assembly.GetExecutingAssembly().GetName().Name;
            
            services.AddDbContext<MoneySaverContext>(options =>
            {
                if (useSQLServer == true)
                {
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                        x => { x.MigrationsAssembly("SQLServerMigrations") ; });
                }
                else
                {
                    options.UseSqlite(configuration.GetConnectionString("SqliteDefaultConnection"),
                        x => { x.MigrationsAssembly("SqliteMigrations"); });
                }
            }, ServiceLifetime.Transient);

            services.AddTransient<IMoneySaverRepository, MoneySaveRepository>();
            services.AddTransient<ILoansRepository, LoanRepository>();
            return services;
        }
    }
}
