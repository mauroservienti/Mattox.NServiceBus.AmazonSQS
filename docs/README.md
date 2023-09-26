# Configuration

NServiceBoXes endpoints can be configured through the [`Microsoft.Extensions.Configuration`](https://www.nuget.org/packages/Microsoft.Extensions.Configuration). All settings are defined in the `NServiceBus:EndpointConfiguration` section. All endpoints share settings comning from the upstream [NServiceBoXes.Endpoints](https://github.com/mauroservienti/NServiceBoXes.Endpoints) package. For more details look at the [documentation in the NServiceBoXes.Endpoints repository](https://github.com/mauroservienti/NServiceBoXes.Endpoints/tree/main/docs).

The NServiceBoXes.Endpoints.AmazonSQS endpoint supports the following configuration options.

- `NServiceBus:EndpointConfiguration:Transport:QueueNamePrefix` allows controlling the [queue name prefix](https://docs.particular.net/transports/sqs/configuration-options#queuenameprefix) used by the transport to locate queues.
- `NServiceBus:EndpointConfiguration:Transport:TopicNamePrefix` allows controlling the [topic name prefix](https://docs.particular.net/transports/sqs/configuration-options#topicnameprefix) used by the transport to locate topics.
- `NServiceBus:EndpointConfiguration:Transport:MaxTimeToLive` allows controlling the [maximum transport retention](https://docs.particular.net/transports/sqs/configuration-options#maxttldays) (in days) for messages.
- `NServiceBus:EndpointConfiguration:Transport:DoNotWrapOutgoingMessages` (`True`/`False`, defult `False`) by default outgoing messages are [wrapped and base64 encoded](https://docs.particular.net/transports/sqs/configuration-options#donotwrapoutgoingmessages), the setting instructs the transport to not wrap and to not base64 encode outgoing messages. 
