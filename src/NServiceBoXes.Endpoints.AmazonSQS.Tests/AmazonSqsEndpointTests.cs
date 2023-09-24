using Microsoft.Extensions.Configuration;

namespace NServiceBoXes.Endpoints.AmazonSQS.Tests;

public class AmazonSqsEndpointTests
{
    [Fact]
    public void When_using_json_config_to_set_name_prefixes()
    {
        var expectedQueueNamePrefix = "my-q";
        var expectedTopicNamePrefix = "my-t";
        
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("When_using_json_config_to_set_name_prefixes.settings.json")
            .Build();

        var endpoint = new AmazonSqsEndpoint(configuration);
        var transportDefinition = endpoint.GetTransportDefinition();

        Assert.Equal(expectedQueueNamePrefix, transportDefinition.QueueNamePrefix);
        Assert.Equal(expectedTopicNamePrefix, transportDefinition.TopicNamePrefix);
    }
}