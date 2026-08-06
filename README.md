# Geoapify API

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Geoapify API SDK for .NET provides access to the Geoapify API REST APIs from .NET applications.

The Geoapify Address Autocomplete API enables the implementation of dynamic location autocomplete fields. It returns real-time suggestions for addresses or places based on partial input provided by the user. The API is designed to enhance user experience by offering relevant location-based suggestions as the user types, making it ideal for form fields that require address input, such as search bars or checkout forms.

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/GeoapifyApi.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [GeoapifyApiClientOptions](GeoapifyApiClientOptions.cs).

```csharp
services.AddGeoapifyApiClient(options =>
    {
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [GeoapifyApiClientOptions](GeoapifyApiClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new GeoapifyApiClientOptions
    {
        Environment = ServerEnvironment.Production,
    };
var client = new GeoapifyApiClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `GeoapifyApiClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

For further assistance, please contact support at info@geoapify.com.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
