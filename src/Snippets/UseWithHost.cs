using Microsoft.Extensions.Hosting;
using NServiceBoXes.Endpoints.AmazonSQS;
using NServiceBus;

namespace Snippets;

public class UseWithHost
{
    static void Usage()
    {
        // begin-snippet: UseWithHost
        var host = Host.CreateDefaultBuilder()
            .UseNServiceBus(hostBuilderContext => new AmazonSqsEndpoint(hostBuilderContext.Configuration))
            .Build();
        // end-snippet
    }
}