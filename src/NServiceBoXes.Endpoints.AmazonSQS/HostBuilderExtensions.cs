using Microsoft.Extensions.Hosting;
using NServiceBus;

namespace NServiceBoXes.Endpoints.AmazonSQS;

public static class HostBuilderExtensions
{
    public static IHostBuilder UseNServiceBusAmazonSqsEndpoint(this IHostBuilder builder, Action<AmazonSqsEndpoint>? endpoint)
    {
        builder.UseNServiceBus(hostBuilderContext=>
        {
            var ep = new AmazonSqsEndpoint(hostBuilderContext.Configuration);
            endpoint?.Invoke(ep);

            return ep;
        });
        
        return builder;
    }
}