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
/// Retrieves geographical location, language, and currency information based on the user's IP address.
/// </summary>
public sealed class IpGeolocationApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal IpGeolocationApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Retrieve geolocation data for a given IP address
    /// </summary>
    /// <param name="apiKey">Your Geoapify API key used to authenticate the request. Sign up for a free API key at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>, which includes up to 3,000 requests per day on the Free plan.</param>
    /// <param name="ip">The IP address to retrieve location information for. If not provided, the request will use the client's IP address automatically.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IpgeolocationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetIpgeolocationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns location details such as country, city, currency, and language based on the specified IP address. If no IP address is provided, the user's own IP address will be automatically detected and used for the lookup. This API can help customize user experiences, such as localizing content or payment forms based on location.
    /// </remarks>
    public Task<IpgeolocationResponse> GetIpgeolocation(string apiKey,
        string? ip,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ipinfo"),
            [],
            [new Param("apiKey", apiKey), new Param("ip", ip)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IpgeolocationResponse>(),
            GetIpgeolocationErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
