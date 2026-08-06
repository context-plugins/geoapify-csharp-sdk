using System.Net.Http;
using GeoapifyApi.Api;
using GeoapifyApi.Core;
using GeoapifyApi.Core.Logging;
using GeoapifyApi.Core.Models;

namespace GeoapifyApi;

/// <summary>
/// The Geoapify Address Autocomplete API enables the implementation of dynamic location autocomplete fields. It returns real-time suggestions for addresses or places based on partial input provided by the user. The API is designed to enhance user experience by offering relevant location-based suggestions as the user types, making it ideal for form fields that require address input, such as search bars or checkout forms.
/// </summary>
public sealed class GeoapifyApiClient
{
    public GeoapifyApiClient(HttpClient httpClient, GeoapifyApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "GeoapifyApiClient/1.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "GeoapifyApiClient");
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
