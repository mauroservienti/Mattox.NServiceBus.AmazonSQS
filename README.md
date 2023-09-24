<img src="assets/icon.png" width="100" />

# NServiceBoXes.Endpoints.AmazonSQS

NServiceBoXes Endpoints simplify [NServiceBus endpoints](https://docs.particular.net/nservicebus/) configuration by providing for supported transports a corresponding NServiceBoXes endpoint with sensible defaults. `NServiceBoXes.Endpoints.AmazonSQS` is the NServiceBoXes endpoint for the [NServiceBus AmamzonSQS transport](https://docs.particular.net/transports/sqs/).

Creating and starting an Amazon SQS endpoint is as easy as:

```csharp
var endpoint = new AmazonSqsEndpoint("my-endpoint");
var endpointInstance = await endpoint.Start();
```

## Microsoft configuration extension support

NServiceBoXes endpoints can be configured through the [`Microsoft.Extensions.Configuration`](https://www.nuget.org/packages/Microsoft.Extensions.Configuration). The above-presented Amazon SQS endpoint can be configured as follows:

```
Host.CreateDefaultBuilder()
    .UseNServiceBus(hostBuilderContext => new AmazonSqsEndpoint(hostBuilderContext.Configuration))
    .Build();
```

The endpoint will retrieve values from the `IConfiguration` object instance.

## Supported endpoints

For more information on all the supported endpoints, refer to the [NServiceBoXes.Endpoints](https://github.com/mauroservienti/NServiceBoXes.Endpoints#supported-endpoints) repository.

## How to get it

- Pre-releases are available on [Feedz.io](https://feedz.io/) ([public feed](https://f.feedz.io/mauroservienti/pre-releases/nuget/index.json))
- Releases on [NuGet.org](https://www.nuget.org/packages?q=NServiceBoXes)







---

Icon — [Box by Angriawan Ditya Zulkarnain](https://thenounproject.com/icon/box-1298424/) from [Noun Project](https://thenounproject.com/browse/icons/term/box/) (CC BY 3.0)
