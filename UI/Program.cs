using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Data.Repositories;
using Microsoft.Extensions.Hosting;
using UI.Forms.ClientsForms;
using Data;
using Service;
using UI.Forms.PeriodsForms;
using UI.Forms;
using Data.Persistence;
using Service.Core.DataModel;

namespace UI
{
    internal static class Program
    {
        public static int CompanyID;
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

            ServiceProvider = host.Services;
            var context = ServiceProvider.GetRequiredService<MoneySaverContext>();

            context.Database.Migrate();

            SeedCompany(context);

            InitialMenu = new InitialMenu();
            Application.Run(InitialMenu);
        }

        public static InitialMenu InitialMenu { get; set; }

        public static IServiceProvider ServiceProvider { get; private set; }
        
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(a => a.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true))
                .ConfigureServices((context, services) => {
                    services.AddInfrastructure(context.Configuration);
                    services.AddServiceLayer();
                    services.AddTransient<FrmClientList>();
                    services.AddTransient<FrmPeriodsList>();
                    services.AddTransient<FrmSavingAccountList>();
                });
        }

        private static void SeedCompany(MoneySaverContext context) 
        {
            if (context.Companies.Any() == false)
            {
                context.Companies.Add(new CompaniesDataModel 
                { CompanyName = "DefaultComp", CurrentAmount = 0, FloatingAmount = 0 });
                context.SaveChanges();
            }

            var defaultCompany = context.Companies.FirstOrDefault();

            if (defaultCompany != null)
                CompanyID = defaultCompany.CompanyID;
        }
    }
}