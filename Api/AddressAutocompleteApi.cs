using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core;
using Geoapify.Core.Exceptions;
using Geoapify.Core.Models;
using Geoapify.Core.Request;
using Geoapify.Core.Response;
using Geoapify.Errors;
using Geoapify.Models.AnyOf;
using Geoapify.Models.Enums;

namespace Geoapify.Api;

/// <summary>
/// Provides real-time address or place suggestions based on user input.
/// </summary>
public sealed class AddressAutocompleteApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal AddressAutocompleteApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Retrieve address suggestions based on input text
    /// </summary>
    /// <param name="text">The partial address or place name to autocomplete. This input is used to generate location-based suggestions.</param>
    /// <param name="apiKey">Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>. The Free plan includes up to 3,000 requests per day.</param>
    /// <param name="format">The format of the response data. Supported formats include JSON, XML, and GeoJSON.</param>
    /// <param name="type">Defines the location type to be searched. Available types include:  - <c>country</c>: Search for countries. - <c>state</c>: Search for states or regions. - <c>city</c>: Search for cities or towns. - <c>postcode</c>: Search for postal codes. - <c>street</c>: Search for specific streets. - <c>amenity</c>: Search for points of interest (e.g., schools, parks, etc.). - <c>locality</c>: Search for administrative areas, which can include postcodes, districts, cities, counties, and states.</param>
    /// <param name="limit">The maximum number of results to return. This limits the number of address suggestions displayed.</param>
    /// <param name="lang">Result language in <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> format (e.g., 'en' for English).</param>
    /// <param name="filter">Refine your search results based on specific geographic criteria. You can apply the following filters to make the suggestions more relevant:  - <b>By circle</b>:     Use <c>circle:lon,lat,radiusMeters</c> to search for places within a circular area, defined by longitude, latitude, and radius in meters.     Example: <c>filter=circle:-87.770231,41.878968,5000</c>    - <b>By rectangle</b>:     Use <c>rect:lon1,lat1,lon2,lat2</c> to search within a rectangular area defined by two longitude and latitude points (southwest and northeast corners).     Example: <c>filter=rect:-89.097540,39.668983,-88.399274,40.383412</c>    - <b>By country</b>:     Use a comma-separated list of ISO 3166-1 Alpha-2 country codes in lowercase to filter results by country. Use <c>'auto'</c> to detect the country by IP address, or <c>'none'</c> to skip country filtering.     Example: <c>filter=countrycode:de,es,fr</c>    - <b>By place</b>:     Use <c>place:placeId</c> to search within a specific boundary, such as a city, district, or postcode, using a <c>place_id</c> returned by other Geoapify APIs (Geocoding, Reverse Geocoding, Places, or Boundaries APIs).     Example: <c>filter=place:51f07665660fc4024059dc0a96dfac6c...</c></param>
    /// <param name="bias">Prioritize search results based on proximity to a point, radius, bounding box, or country without limiting the search area. This is useful for displaying nearby results first while allowing global search:  - <b>By circle</b>:     Use <c>circle:lon,lat,radiusMeters</c> to prioritize results from within a circular area, and then search worldwide.     Example: <c>bias=circle:-87.770231,41.878968,5000</c>    - <b>By rectangle</b>:     Use <c>rect:lon1,lat1,lon2,lat2</c> to prioritize results from within a rectangular area (defined by two longitude and latitude points representing the southwest and northeast corners), and then search globally.     Example: <c>bias=rect:-89.097540,39.668983,-88.399274,40.383412</c>    - <b>By country</b>:     Use comma-separated ISO 3166-1 Alpha-2 country codes in lowercase to prioritize results from those countries first. Use <c>'auto'</c> to detect the country by IP address, or <c>'none'</c> to skip country bias.     Example: <c>bias=countrycode:de,es,fr</c>    - <b>By location</b>:     Use <c>proximity:lon,lat</c> to prioritize results based on distance from a specific longitude and latitude.     Example: <c>bias=proximity:41.2257145,52.971411</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeocodeAutocompleteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAddressAutocompleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint returns a list of suggested addresses and associated location details (such as country, city, street, and more) based on the partial text provided by the user. It helps implement autocomplete functionality for address inputs, enhancing user experience by offering real-time suggestions.
    /// </remarks>
    public Task<GeocodeAutocompleteResponse> GetAddressAutocomplete(string text,
        string apiKey,
        Format? format,
        Type3? type,
        int? limit,
        string? lang,
        string? filter,
        string? bias,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/geocode/autocomplete"),
            [],
            [new Param("text", text),
                new Param("apiKey", apiKey),
                new Param("format", format),
                new Param("type", type),
                new Param("limit", limit),
                new Param("lang", lang),
                new Param("filter", filter),
                new Param("bias", bias)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GeocodeAutocompleteResponse>(),
            GetAddressAutocompleteErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
