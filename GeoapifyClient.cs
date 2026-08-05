using System.Net.Http;
using Geoapify.Api;
using Geoapify.Core;
using Geoapify.Core.Logging;
using Geoapify.Core.Models;

namespace Geoapify;

/// <summary>
/// The Geoapify Address Autocomplete API enables the implementation of dynamic location autocomplete fields. It returns real-time suggestions for addresses or places based on partial input provided by the user. The API is designed to enhance user experience by offering relevant location-based suggestions as the user types, making it ideal for form fields that require address input, such as search bars or checkout forms., The IP Geolocation API provides a convenient way to detect a user's geographical location based on their IP address. This API offers valuable data, such as the user's country, region, city, and timezone, as well as language and currency information, which can be used to enhance user experiences—like customizing content, localizing payment forms, or adjusting language settings., The Isoline API calculates areas that are accessible from a specific location within a certain time (isochrones) or distance (isodistances). It helps determine how far you can travel from a given point based on various transportation modes, providing valuable insights for business planning, logistics, or finding optimal locations for services. This API is ideal for businesses looking to explore reachable areas, optimize service coverage, or identify new opportunities., The Map Matching API allows you to align raw geographic coordinates, such as GPS tracks, to the nearest roads and pathways on the map. This is useful for improving the accuracy of location data, especially for routes and paths that follow the road network. The API supports various transportation modes, including cars, buses, delivery trucks, bicycles, and walking, ensuring accurate results for different types of travel., The Places API enables querying local points of interest and amenities. You can search for places within a city, a radius, an isoline, or a bounding box, filtered by categories, conditions (e.g., free Wi-Fi, wheelchair accessibility)., The Reverse Geocoding API allows you to convert geographic coordinates (latitude and longitude) into human-readable addresses. This is particularly useful for obtaining an address based on GPS coordinates or determining the location of a point of interest, such as when a user clicks on a map. Common use cases include finding a customer’s address from their GPS data or identifying the address of a specific building., The Route Matrix API enables you to calculate up to 1,000 travel distances and times between multiple locations in a single request. For even larger datasets, you can combine multiple matrices from separate API calls. The API supports various transportation modes, including passenger cars, delivery trucks, small motor vehicles, and walking. It's ideal for logistics, fleet management, or any application that requires time-distance analysis between numerous points., The Routing API enables route calculation between two or more waypoints via HTTP GET requests. It supports various transportation modes, including cars, delivery trucks, cargo vans, bicycles, motor scooters, and walking. The API returns detailed route data, including step-by-step directions and turn-by-turn navigation, making it ideal for applications that require real-time route planning for logistics, deliveries, or personal navigation.
/// </summary>
public sealed class GeoapifyClient
{
    public GeoapifyClient(HttpClient httpClient, GeoapifyClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "GeoapifyClient/1.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "GeoapifyClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        AddressAutocompleteApi = new AddressAutocompleteApi(rawClient, server);
        IpGeolocationApi = new IpGeolocationApi(rawClient, server);
        IsolineApi = new IsolineApi(rawClient, server);
        MapMatchingApi = new MapMatchingApi(rawClient, server);
        PlacesApi = new PlacesApi(rawClient, server);
        ReverseGeocodingApi = new ReverseGeocodingApi(rawClient, server);
        RouteMatrixApi = new RouteMatrixApi(rawClient, server);
        RoutingApi = new RoutingApi(rawClient, server);
    }

    /// <summary>
    /// Provides real-time address or place suggestions based on user input.
    /// </summary>
    public AddressAutocompleteApi AddressAutocompleteApi { get; }

    /// <summary>
    /// Retrieves geographical location, language, and currency information based on the user's IP address.
    /// </summary>
    public IpGeolocationApi IpGeolocationApi { get; }

    /// <summary>
    /// API for calculating isochrones (time-based areas) and isodistances (distance-based areas) from a given location.
    /// </summary>
    public IsolineApi IsolineApi { get; }

    /// <summary>
    /// Matches geographical coordinates, such as GPS tracks, to the closest roads and pathways in the existing road network, improving the accuracy of location data for various transportation modes.
    /// </summary>
    public MapMatchingApi MapMatchingApi { get; }

    /// <summary>
    /// API for querying points of interest and amenities.
    /// </summary>
    public PlacesApi PlacesApi { get; }

    /// <summary>
    /// Converts geographic coordinates into addresses.
    /// </summary>
    public ReverseGeocodingApi ReverseGeocodingApi { get; }

    /// <summary>
    /// Generates a time-distance matrix between source and target locations.
    /// </summary>
    public RouteMatrixApi RouteMatrixApi { get; }

    /// <summary>
    /// Provides route calculations for various transportation modes, including automobiles, trucks, bicycles, and walking.
    /// </summary>
    public RoutingApi RoutingApi { get; }
}
