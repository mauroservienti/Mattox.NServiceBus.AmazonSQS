# Configuration

NServiceBoXes endpoints can be configured through the [`Microsoft.Extensions.Configuration`](https://www.nuget.org/packages/Microsoft.Extensions.Configuration). All settings are defined in the `NServiceBus:EndpointConfiguration` section. All endpoints share settings comning from the upstream [NServiceBoXes.Endpoints](https://github.com/mauroservienti/NServiceBoXes.Endpoints) package. For more details look at the [documentation in the NServiceBoXes.Endpoints repository](https://github.com/mauroservienti/NServiceBoXes.Endpoints/tree/main/docs).

The NServiceBoXes.Endpoints.AmazonSQS endpoint supports the following configuration options.

- `NServiceBus:EndpointConfiguration:Transport:QueueNamePrefix`
- `NServiceBus:EndpointConfiguration:Transport:TopicNamePrefix`
- `NServiceBus:EndpointConfiguration:Transport:MaxTimeToLive`
- `NServiceBus:EndpointConfiguration:Transport:DoNotWrapOutgoingMessages`
