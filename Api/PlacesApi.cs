using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core;
using Geoapify.Core.Exceptions;
using Geoapify.Core.Models;
using Geoapify.Core.Request;
using Geoapify.Core.Response;
using Geoapify.Errors;

namespace Geoapify.Api;

/// <summary>
/// API for querying points of interest and amenities.
/// </summary>
public sealed class PlacesApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PlacesApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Search for places by category and location
    /// </summary>
    /// <param name="apiKey">The API key for Geoapify services.</param>
    /// <param name="categories">Comma-separated list of place categories (e.g., catering.restaurant, catering.cafe).</param>
    /// <param name="conditions">Filter results by conditions (e.g., wheelchair accessibility, internet access). Check supported values for conditions.</param>
    /// <param name="filter">Filter results by geometry. For example, use <c>rect:lon1,lat1,lon2,lat2</c> for a bounding box or <c>circle:lon,lat,radiusMeters</c> for a circle.</param>
    /// <param name="bias">Search places near the specified location. Note, the search will prioritize places within 50km.</param>
    /// <param name="limit">Maximum number of results per page.</param>
    /// <param name="offset">Offset to the first result index for pagination.</param>
    /// <param name="lang">The language of the result. Supports 2-character ISO 639-1 language codes (e.g., "en").</param>
    /// <param name="name">Filter places by the given name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPlacesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns points of interest based on specified location and filters. You can filter places by category, conditions (e.g., wheelchair accessible), and geometry (bounding box, circle, etc.).
    /// </remarks>
    public Task GetPlaces(string apiKey,
        string categories,
        string? conditions,
        string? filter,
        string? bias,
        int? limit,
        int? offset,
        string? lang,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default1("/places"),
            [],
            [new Param("apiKey", apiKey),
                new Param("categories", categories),
                new Param("conditions", conditions),
                new Param("filter", filter),
                new Param("bias", bias),
                new Param("limit", limit),
                new Param("offset", offset),
                new Param("lang", lang),
                new Param("name", name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetPlacesErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
