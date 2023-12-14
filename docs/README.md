# Configuration

Maddox.NServiceBus endpoints can be configured through the [`Microsoft.Extensions.Configuration`](https://www.nuget.org/packages/Microsoft.Extensions.Configuration). All settings are defined in the `NServiceBus:EndpointConfiguration` section. All endpoints share settings comning from the upstream [Maddox.NServiceBus](https://github.com/mauroservienti/Maddox.NServiceBus) package. For more details look at the [documentation in the Maddox.NServiceBus repository](https://github.com/mauroservienti/Maddox.NServiceBus/tree/main/docs).

The Maddox.NServiceBus.AmazonSQS endpoint supports the following configuration options.

- `NServiceBus:EndpointConfiguration:Transport:DoNotWrapOutgoingMessages` (`True`/`False`, defult `True`) by default outgoing messages are [not wrapped and not base64 encoded](https://docs.particular.net/transports/sqs/configuration-options#donotwrapoutgoingmessages), the setting influences the transport behavior when it comes to wrap and base64 encode outgoing messages.
- `NServiceBus:EndpointConfiguration:Transport:QueueNamePrefix` allows controlling the [queue name prefix](https://docs.particular.net/transports/sqs/configuration-options#queuenameprefix) used by the transport to locate queues.
- `NServiceBus:EndpointConfiguration:Transport:TopicNamePrefix` allows controlling the [topic name prefix](https://docs.particular.net/transports/sqs/configuration-options#topicnameprefix) used by the transport to locate topics.
- `NServiceBus:EndpointConfiguration:Transport:MaxTimeToLive` allows controlling the [maximum transport retention](https://docs.particular.net/transports/sqs/configuration-options#maxttldays) (in days) for messages.
