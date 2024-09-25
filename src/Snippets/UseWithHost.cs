using Microsoft.Extensions.Hosting;
using NServiceBoXes.Endpoints.AmazonSQS;
using NServiceBus;

namespace Snippets;

public class UseWithHost
{
    static void Usage()
    {
        // begin-snippet: UseWithHost
        Host.CreateDefaultBuilder()
            .UseNServiceBus(hostBuilderContext => new AmazonSqsEndpoint(hostBuilderContext.Configuration))
            .Build();
        // end-snippet
        
        // begin-snippet: UseWithHostUseNServiceBusAmazonSqsEndpoint
        Host.CreateDefaultBuilder()
            .UseNServiceBusAmazonSqsEndpoint()
            .Build();
        // end-snippet
        
        // begin-snippet: UseWithHostUseNServiceBusAmazonSqsEndpointWithEndpointName
        Host.CreateDefaultBuilder()
            .UseNServiceBusAmazonSqsEndpoint("MyEndpointName")
            .Build();
        // end-snippet
    }
}