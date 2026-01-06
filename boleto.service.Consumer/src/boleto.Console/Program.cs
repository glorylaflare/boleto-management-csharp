using boleto.Console;
using boleto.Console.Helper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = HostServiceConfiguration.HostConfiguration();

await host.RunAsync();