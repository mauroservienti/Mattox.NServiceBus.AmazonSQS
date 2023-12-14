using Amazon.SimpleNotificationService;
using Amazon.SQS;
using Microsoft.Extensions.Configuration;
using NServiceBus;

namespace Maddox.NServiceBus.AmazonSQS;

public class AmazonSqsEndpointConfigurationManager : EndpointConfigurationManager<SqsTransport>
{
    public AmazonSqsEndpointConfigurationManager()
    {
    }

    public AmazonSqsEndpointConfigurationManager(IAmazonSQS amazonSqsClient,
        IAmazonSimpleNotificationService amazonSnsClient)
    {
        InitializeClients(amazonSqsClient, amazonSnsClient);
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

    internal void InitializeClients(IAmazonSQS amazonSqsClient,
        IAmazonSimpleNotificationService amazonSnsClient)
    {
        this._amazonSqsClient = amazonSqsClient ?? throw new ArgumentNullException(nameof(amazonSqsClient));
        this._amazonSnsClient = amazonSnsClient ?? throw new ArgumentNullException(nameof(amazonSnsClient));
    }

    IAmazonSQS? _amazonSqsClient;
    IAmazonSimpleNotificationService? _amazonSnsClient;
}