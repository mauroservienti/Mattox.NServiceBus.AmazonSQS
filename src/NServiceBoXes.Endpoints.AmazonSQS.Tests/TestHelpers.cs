using NServiceBus.Configuration.AdvancedExtensibility;
using NServiceBus.Transport;

namespace NServiceBoXes.Endpoints.AmazonSQS.Tests;

public static class TestHelpers
{
    public static SqsTransport GetTransportDefinition(this AmazonSqsEndpoint endpoint)
    {
        var settings = ((EndpointConfiguration)endpoint).GetSettings();
        var transportDefinition = settings.Get<TransportDefinition>();
        
        return (SqsTransport)transportDefinition;
    }
}