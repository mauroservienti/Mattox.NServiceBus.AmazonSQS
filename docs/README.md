# Configuration

Mattox endpoints can be configured through the [`Microsoft.Extensions.Configuration`](https://www.nuget.org/packages/Microsoft.Extensions.Configuration). All settings are defined in the `NServiceBus:EndpointConfiguration` section. All endpoints share settings comning from the upstream [Mattox.Endpoints](https://github.com/mauroservienti/Mattox.NServiceBus) package. For more details look at the [documentation in the Mattox.Endpoints repository](https://github.com/mauroservienti/Mattox.NServiceBus/tree/main/docs).

The Mattox.Endpoints.AmazonSQS endpoint supports the following configuration options.

- `NServiceBus:EndpointConfiguration:Transport:QueueNamePrefix` allows controlling the [queue name prefix](https://docs.particular.net/transports/sqs/configuration-options#queuenameprefix) used by the transport to locate queues.
- `NServiceBus:EndpointConfiguration:Transport:TopicNamePrefix` allows controlling the [topic name prefix](https://docs.particular.net/transports/sqs/configuration-options#topicnameprefix) used by the transport to locate topics.
- `NServiceBus:EndpointConfiguration:Transport:MaxTimeToLive` allows controlling the [maximum transport retention](https://docs.particular.net/transports/sqs/configuration-options#maxttldays) (in days) for messages.
- `NServiceBus:EndpointConfiguration:Transport:DoNotWrapOutgoingMessages` (`True`/`False`, defult `True`) by default outgoing messages are [not wrapped and not base64 encoded](https://docs.particular.net/transports/sqs/configuration-options#donotwrapoutgoingmessages), the setting influences the transport behavior when it comes to wrap and base64 encode outgoing messages.
