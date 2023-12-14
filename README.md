<img src="assets/icon.png" width="100" />

# Maddox.NServiceBus.AmazonSQS

Maddox.NServiceBus simplifies [NServiceBus endpoints](https://docs.particular.net/nservicebus/) configuration by providing for supported transports a corresponding Maddox.NServiceBus endpoint with sensible defaults. `Maddox.NServiceBus.AmazonSQS` is the Maddox.NServiceBus endpoint for the [NServiceBus AmamzonSQS transport](https://docs.particular.net/transports/sqs/).

Creating and starting an Amazon SQS endpoint is as easy as:

<!-- snippet: BasicEndpointUsage -->
<a id='snippet-basicendpointusage'></a>
```cs
var endpoint = new AmazonSqsEndpoint("my-endpoint");
var endpointInstance = await endpoint.Start();
```
<sup><a href='/src/Snippets/BasicEndpoint.cs#L9-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-basicendpointusage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

## Microsoft configuration extension support

Maddox.NServiceBus endpoints can be configured through the [`Microsoft.Extensions.Configuration`](https://www.nuget.org/packages/Microsoft.Extensions.Configuration). The above-presented Amazon SQS endpoint can be configured as follows:

<!-- snippet: UseWithHost -->
<a id='snippet-usewithhost'></a>
```cs
Host.CreateDefaultBuilder()
    .UseNServiceBus(hostBuilderContext => new AmazonSqsEndpoint(hostBuilderContext.Configuration))
    .Build();
```
<sup><a href='/src/Snippets/UseWithHost.cs#L11-L15' title='Snippet source file'>snippet source</a> | <a href='#snippet-usewithhost' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

The endpoint will retrieve values from the `IConfiguration` object instance.

## Supported endpoints

For more information on all the supported endpoints, refer to the [Maddox.NServiceBus](https://github.com/mauroservienti/Maddox.NServiceBus#supported-endpoints) repository.

## How to get it

- Releases on [NuGet.org](https://www.nuget.org/packages?q=NServiceBoXes)
- Pre-releases are available on [Feedz.io](https://feedz.io/) ([public feed](https://f.feedz.io/mauroservienti/pre-releases/nuget/index.json))

---

Icon — [Box by Angriawan Ditya Zulkarnain](https://thenounproject.com/icon/box-1298424/) from [Noun Project](https://thenounproject.com/browse/icons/term/box/) (CC BY 3.0)
