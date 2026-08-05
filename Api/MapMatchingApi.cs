using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core;
using Geoapify.Core.Exceptions;
using Geoapify.Core.Models;
using Geoapify.Core.Request;
using Geoapify.Core.Response;
using Geoapify.Errors;
using Geoapify.Models;

namespace Geoapify.Api;

/// <summary>
/// Matches geographical coordinates, such as GPS tracks, to the closest roads and pathways in the existing road network, improving the accuracy of location data for various transportation modes.
/// </summary>
public sealed class MapMatchingApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal MapMatchingApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Match GPS coordinates to the road network
    /// </summary>
    /// <param name="apiKey">Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>. The Free plan includes up to 3,000 requests per day.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MapMatchingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MapMatchingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Aligns geographical coordinates, such as GPS tracks, to the nearest roads and pathways on the existing road network. This endpoint supports various travel modes, including driving, walking, and cycling, to ensure accurate route matching based on the mode of transportation.
    /// </remarks>
    public Task<MapMatchingResponse> MapMatching(string apiKey,
        MapmatchingRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/mapmatching"),
            [],
            [new Param("apiKey", apiKey)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<MapMatchingResponse>(),
            MapMatchingErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
