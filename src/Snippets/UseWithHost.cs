using Microsoft.Extensions.Hosting;
using Mattox.NServiceBus.AmazonSQS;
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
    }
}