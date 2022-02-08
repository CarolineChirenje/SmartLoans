using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartMail;
using System;

namespace SmartAsyncMailing
{
    class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).UseSystemd().ConfigureServices((Action<HostBuilderContext, IServiceCollection>)((hostContext, services) =>
        {
        
            services.AddHostedService<Worker>();
            services.AddSingleton<IMailService, MailService>();
        }));
    }
}
