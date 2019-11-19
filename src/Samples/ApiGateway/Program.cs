using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jimu.Client.ApiGateway;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Jimu.Client.ApplicationClient.RunWebHost((build, container) => build.ConfigureWebHostDefaults(webBuilder =>
            // {
            //     webBuilder.UseStartup<Startup>();
            // }));



            //var hostBuilder = Host.CreateDefaultBuilder();
            //hostBuilder.UseJimu();
            //hostBuilder.Build().Run();

            Jimu.Client.ApplicationWebClient.Instance.Run();
        }
    }
}