using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
