using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GeoapifyApi.Core;
using GeoapifyApi.Core.Exceptions;
using GeoapifyApi.Core.Models;
using GeoapifyApi.Core.Request;
using GeoapifyApi.Core.Response;
using GeoapifyApi.Errors;
using GeoapifyApi.Models;

namespace GeoapifyApi.Api;

/// <summary>
/// Generates a time-distance matrix between source and target locations.
/// </summary>
public sealed class RouteMatrixApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal RouteMatrixApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Generate a time-distance matrix between source and target locations
    /// </summary>
    /// <param name="apiKey">Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>. The Free plan includes up to 3,000 requests per day.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RouteMatrixResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GenerateRouteMatrixError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a time-distance matrix for the specified source and target locations, providing valuable data for route optimization and travel analytics. The API supports various transportation modes, including driving, walking, and cycling, making it ideal for logistics, route planning, and other mobility applications.
    /// </remarks>
    public Task<RouteMatrixResponse> GenerateRouteMatrix(string apiKey,
        RoutematrixRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/routematrix"),
            [],
            [new Param("apiKey", apiKey)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RouteMatrixResponse>(),
            GenerateRouteMatrixErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
