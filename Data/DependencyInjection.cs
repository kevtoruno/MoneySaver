using Data.Persistence;
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
            /*services.AddDbContext<MoneySaverContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }, ServiceLifetime.Transient);*/

            services.AddDbContext<MoneySaverContext>(x =>
            {
                x.UseSqlite(configuration.GetConnectionString("SqliteDefaultConnection"));
            }, ServiceLifetime.Transient);

            var x = configuration.GetConnectionString("DefaultConnection");

            services.AddTransient<IMoneySaverRepository, MoneySaveRepository>();

            return services;
        }
    }
}
