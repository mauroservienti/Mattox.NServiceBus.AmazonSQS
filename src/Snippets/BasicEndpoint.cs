using Mattox.NServiceBus.AmazonSQS;

namespace Snippets;

public class BasicEndpoint
{
    static async Task BasicEndpointUsage()
    {
        // begin-snippet: BasicEndpointUsage
        var endpoint = new AmazonSqsEndpoint("my-endpoint");
        var endpointInstance = await endpoint.Start();
        // end-snippet
    }
}