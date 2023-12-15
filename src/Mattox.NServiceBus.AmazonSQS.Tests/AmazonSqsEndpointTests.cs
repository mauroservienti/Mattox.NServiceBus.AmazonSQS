using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Mattox.NServiceBus.AmazonSQS.Tests;

public class AmazonSqsEndpointTests
{
    [Fact]
    public void When_using_json_config_to_set_name_prefixes()
    {
        var jsonSettingsFileName = "When_using_json_config_to_set_name_prefixes.settings.json";
        var json = JObject.Parse(File.ReadAllText(jsonSettingsFileName));
        
        var expectedQueueNamePrefix = json["NServiceBus"]!["EndpointConfiguration"]!["Transport"]!["QueueNamePrefix"]!.Value<string>();
        var expectedTopicNamePrefix = json["NServiceBus"]!["EndpointConfiguration"]!["Transport"]!["TopicNamePrefix"]!.Value<string>();
        
        var configuration = new ConfigurationBuilder()
            .AddJsonFile(jsonSettingsFileName)
            .Build();

        var endpoint = new AmazonSqsEndpoint(configuration);
        var transportDefinition = endpoint.GetTransportDefinition();

        Assert.Equal(expectedQueueNamePrefix, transportDefinition.QueueNamePrefix);
        Assert.Equal(expectedTopicNamePrefix, transportDefinition.TopicNamePrefix);
    }
}