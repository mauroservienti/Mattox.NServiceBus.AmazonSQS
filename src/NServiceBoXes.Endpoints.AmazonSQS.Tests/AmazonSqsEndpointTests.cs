using Microsoft.Extensions.Configuration;
using NServiceBus;
using NServiceBus.Configuration.AdvancedExtensibility;

namespace NServiceBoXes.Endpoints.AmazonSQS.Tests;

public class AmazonSqsEndpointTests
{
    [Fact]
    public void Basic_endpoint_respect_name()
    {
        var expectedEndpointName = "my-endpoint";
        var endpoint = new AmazonSqsEndpoint(expectedEndpointName);
        EndpointConfiguration endpointConfiguration = endpoint;
        
        var actualEndpointName = endpointConfiguration.GetSettings().EndpointName();
        
        Assert.Equal(expectedEndpointName, actualEndpointName);
    }
    
    [Fact]
    public void Using_json_configuration_respect_name()
    {
        var expectedEndpointName = "my-endpoint";
     
        var config = new ConfigurationBuilder()
            .AddJsonFile("endpoint.settings.json")
            .Build();
        
        var endpoint = new AmazonSqsEndpoint(config);
        EndpointConfiguration endpointConfiguration = endpoint;
        
        var actualEndpointName = endpointConfiguration.GetSettings().EndpointName();
        
        Assert.Equal(expectedEndpointName, actualEndpointName);
    }
    
    [Fact]
    public void Using_env_var_configuration_respect_name()
    {
        var expectedEndpointName = "my-endpoint";
        Environment.SetEnvironmentVariable("NServiceBus:EndpointConfiguration:EndpointName", expectedEndpointName);
        
        var config = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();
        
        var endpoint = new AmazonSqsEndpoint(config);
        EndpointConfiguration endpointConfiguration = endpoint;
        
        var actualEndpointName = endpointConfiguration.GetSettings().EndpointName();
        
        Assert.Equal(expectedEndpointName, actualEndpointName);
    }
}