using SqliteMigrations.Persistence;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Core.Interfaces;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            bool useSQLServer = true;

            var assembly = Assembly.GetExecutingAssembly().GetName().Name;
            
            services.AddDbContext<MoneySaverContext>(options =>
            {
                if (useSQLServer == true)
                {
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                        x => { x.MigrationsAssembly(assembly) ; });
                }
                else
                {
                    options.UseSqlite(configuration.GetConnectionString("SqliteDefaultConnection"),
                        x => { x.MigrationsAssembly("SqliteMigrations"); });
                }
            }, ServiceLifetime.Transient);

            services.AddTransient<IMoneySaverRepository, MoneySaveRepository>();

            return services;
        }
    }
}
