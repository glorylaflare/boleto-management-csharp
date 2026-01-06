using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleto.Console.Helper
{
    public class HostServiceConfiguration
    {
        public static IHost HostConfiguration()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                })
                .Build();
            return host;
        }
    }
}
