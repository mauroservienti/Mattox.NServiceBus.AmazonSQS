using Amazon.SimpleNotificationService;
using Amazon.SQS;
using Microsoft.Extensions.Configuration;
using NServiceBus;

namespace Maddox.NServiceBus.AmazonSQS;

public class AmazonSqsEndpoint : NServiceBusEndpoint<AmazonSqsEndpointConfigurationManager, SqsTransport>
{
    readonly IAmazonSQS? _amazonSqsClient;
    readonly IAmazonSimpleNotificationService? _amazonSnsClient;

    public AmazonSqsEndpoint(IConfiguration configuration)
        : base(configuration)
    {
        
    }

    public AmazonSqsEndpoint(string endpointName, IConfiguration? configuration = null)
        : base(endpointName, configuration)
    {
    }

    public AmazonSqsEndpoint(string endpointName, IAmazonSQS amazonSqsClient,
        IAmazonSimpleNotificationService amazonSnsClient, IConfiguration? configuration = null)
        : base(endpointName, configuration)
    {
        ConfigurationManager.InitializeClients(amazonSqsClient, amazonSnsClient);
    }
}