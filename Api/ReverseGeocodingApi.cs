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
/// Converts geographic coordinates into addresses.
/// </summary>
public sealed class ReverseGeocodingApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ReverseGeocodingApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Retrieve address from geographic coordinates
    /// </summary>
    /// <param name="lat">The latitude of the location to reverse geocode.</param>
    /// <param name="lon">The longitude of the location to reverse geocode.</param>
    /// <param name="apiKey">Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>. The Free plan includes up to 3,000 requests per day.</param>
    /// <param name="format">The format of the response (JSON, XML, or GeoJSON).</param>
    /// <param name="limit">The maximum number of results to return.</param>
    /// <param name="type">Defines the location type to be searched. Available types include:  - <c>country</c>: Search for countries. - <c>state</c>: Search for states or regions. - <c>city</c>: Search for cities or towns. - <c>postcode</c>: Search for postal codes. - <c>street</c>: Search for specific streets. - <c>amenity</c>: Search for points of interest (e.g., schools, parks, etc.).</param>
    /// <param name="lang">Result language in <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> format (e.g., 'en' for English).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeocodeReverseResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetReverseGeocodeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an address and its components (such as city, postcode, street, etc.) based on the provided latitude and longitude coordinates. Use this endpoint to convert coordinates into a human-readable address for various use cases, such as map applications or location-based services.
    /// </remarks>
    public Task<GeocodeReverseResponse> GetReverseGeocode(double lat,
        double lon,
        string apiKey,
        Format? format,
        int? limit,
        Type3? type,
        string? lang,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/geocode/reverse"),
            [],
            [new Param("lat", lat),
                new Param("lon", lon),
                new Param("apiKey", apiKey),
                new Param("format", format),
                new Param("limit", limit),
                new Param("type", type),
                new Param("lang", lang)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GeocodeReverseResponse>(),
            GetReverseGeocodeErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
