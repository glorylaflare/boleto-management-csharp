using boleto.Console.Helper;
using Microsoft.Extensions.Hosting;

var host = HostServiceConfiguration.HostConfiguration();

await host.RunAsync();