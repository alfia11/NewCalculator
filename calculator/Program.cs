
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using iRely.Common;
using NLog.Extensions.Logging;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());
            var builder = new HostBuilder()
   .ConfigureServices((hostContext, services) =>
   {
   //    services.AddScoped<calculator>();
      // services.AddScoped<IBusinessLayer, BusinessLayer>();
       //services.AddSingleton<IDataAccessLayer, CDataAccessLayer>();
       services.AddLogging(option =>
       {
           option.SetMinimumLevel(LogLevel.Information);
           option.AddNLog("nlog.config");
       });
   });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                   // var form1 = services.GetRequiredService<calculator>();
                   // Application.Run(form1);

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }
    }
}
