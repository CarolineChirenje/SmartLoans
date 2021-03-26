using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmartHelper;

namespace SmartSave
{
    public class Program
    {


        public static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json", optional: true)
          .AddEnvironmentVariables()
           .Build();
            bool _useUrlForSite = config.GetValue<bool>("UseUrlForSite");
            if (_useUrlForSite)
            {
                string _url = config.GetValue<string>("UserUrl");
                if (String.IsNullOrEmpty(_url))
                    _url = "http://*:1989";

                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseUrls(_url)
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseStartup<Startup>()
                    .Build();

                host.Run();
            }
            else
            {
                CreateWebHostBuilder(args).Build().Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();


    }

}
