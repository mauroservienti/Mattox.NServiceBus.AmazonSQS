using Amazon.SimpleNotificationService;
using Amazon.SQS;
using Microsoft.Extensions.Configuration;
using NServiceBus;

namespace Mattox.NServiceBus.AmazonSQS;

public class AmazonSqsEndpoint : NServiceBusEndpoint<SqsTransport>
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
        _amazonSqsClient = amazonSqsClient ?? throw new ArgumentNullException(nameof(amazonSqsClient));
        _amazonSnsClient = amazonSnsClient ?? throw new ArgumentNullException(nameof(amazonSnsClient));
    }

    protected override SqsTransport CreateTransport(IConfigurationSection? transportConfigurationSection)
    {
        SqsTransport transport;
        if (_amazonSqsClient != null && _amazonSnsClient != null)
        {
            transport = new SqsTransport(_amazonSqsClient, _amazonSnsClient);
        }
        else
        {
            transport = new SqsTransport();
        }

        ApplyCommonTransportSettings(transportConfigurationSection, transport);
        
        transport.DoNotWrapOutgoingMessages = true;
        if (transportConfigurationSection?["DoNotWrapOutgoingMessages"] is { } doNotWrapOutgoingMessages)
        {
            transport.DoNotWrapOutgoingMessages = bool.Parse(doNotWrapOutgoingMessages);
        }

        if (transportConfigurationSection?["QueueNamePrefix"] is { } queueNamePrefix)
        {
            transport.QueueNamePrefix = queueNamePrefix;
        }

        if (transportConfigurationSection?["TopicNamePrefix"] is { } topicNamePrefix)
        {
            transport.TopicNamePrefix = topicNamePrefix;
        }

        if (transportConfigurationSection?["MaxTimeToLive"] is { } maxTimeToLive)
        {
            transport.MaxTimeToLive = TimeSpan.Parse(maxTimeToLive);
        }

        return transport;
    }
}