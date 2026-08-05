# Geoapify

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Geoapify SDK for .NET provides access to the Geoapify REST APIs from .NET applications.

The Geoapify Address Autocomplete API enables the implementation of dynamic location autocomplete fields. It returns real-time suggestions for addresses or places based on partial input provided by the user. The API is designed to enhance user experience by offering relevant location-based suggestions as the user types, making it ideal for form fields that require address input, such as search bars or checkout forms., The IP Geolocation API provides a convenient way to detect a user's geographical location based on their IP address. This API offers valuable data, such as the user's country, region, city, and timezone, as well as language and currency information, which can be used to enhance user experiences—like customizing content, localizing payment forms, or adjusting language settings., The Isoline API calculates areas that are accessible from a specific location within a certain time (isochrones) or distance (isodistances). It helps determine how far you can travel from a given point based on various transportation modes, providing valuable insights for business planning, logistics, or finding optimal locations for services. This API is ideal for businesses looking to explore reachable areas, optimize service coverage, or identify new opportunities., The Map Matching API allows you to align raw geographic coordinates, such as GPS tracks, to the nearest roads and pathways on the map. This is useful for improving the accuracy of location data, especially for routes and paths that follow the road network. The API supports various transportation modes, including cars, buses, delivery trucks, bicycles, and walking, ensuring accurate results for different types of travel., The Places API enables querying local points of interest and amenities. You can search for places within a city, a radius, an isoline, or a bounding box, filtered by categories, conditions (e.g., free Wi-Fi, wheelchair accessibility)., The Reverse Geocoding API allows you to convert geographic coordinates (latitude and longitude) into human-readable addresses. This is particularly useful for obtaining an address based on GPS coordinates or determining the location of a point of interest, such as when a user clicks on a map. Common use cases include finding a customer’s address from their GPS data or identifying the address of a specific building., The Route Matrix API enables you to calculate up to 1,000 travel distances and times between multiple locations in a single request. For even larger datasets, you can combine multiple matrices from separate API calls. The API supports various transportation modes, including passenger cars, delivery trucks, small motor vehicles, and walking. It's ideal for logistics, fleet management, or any application that requires time-distance analysis between numerous points., The Routing API enables route calculation between two or more waypoints via HTTP GET requests. It supports various transportation modes, including cars, delivery trucks, cargo vans, bicycles, motor scooters, and walking. The API returns detailed route data, including step-by-step directions and turn-by-turn navigation, making it ideal for applications that require real-time route planning for logistics, deliveries, or personal navigation.

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/Geoapify.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [GeoapifyClientOptions](GeoapifyClientOptions.cs).

```csharp
services.AddGeoapifyClient(options =>
    {
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [GeoapifyClientOptions](GeoapifyClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new GeoapifyClientOptions
    {
        Environment = ServerEnvironment.Production,
    };
var client = new GeoapifyClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `GeoapifyClient` instance** for the lifetime of your application and
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
