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
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Api;

/// <summary>
/// API for calculating isochrones (time-based areas) and isodistances (distance-based areas) from a given location.
/// </summary>
public sealed class IsolineApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal IsolineApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Calculate Isochrones or Isodistances
    /// </summary>
    /// <param name="apiKey">Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>. The Free plan includes up to 3,000 requests per day.</param>
    /// <param name="lat">The latitude of the location from which to calculate the isoline.</param>
    /// <param name="lon">The longitude of the location from which to calculate the isoline.</param>
    /// <param name="type">Specifies whether to calculate an isochrone (based on travel time) or an isodistance (based on distance).</param>
    /// <param name="mode">Determines how the accessible area is calculated based on the type of transportation or movement.  Available options include: - <c>drive</c>: Standard car or automobile. - <c>light_truck</c>: Light-duty truck. - <c>medium_truck</c>: Medium-duty truck. - <c>truck</c>: General truck. - <c>heavy_truck</c>: Heavy-duty truck. - <c>truck_dangerous_goods</c>: Truck carrying hazardous materials. - <c>long_truck</c>: Long or articulated truck. - <c>bus</c>: Public or private bus. - <c>scooter</c>: Motorized scooter. - <c>motorcycle</c>: Motorbike. - <c>bicycle</c>: Standard bicycle. - <c>mountain_bike</c>: Mountain bike. - <c>road_bike</c>: Road bicycle. - <c>walk</c>: Walking on foot. - <c>hike</c>: Hiking, often on trails or rugged terrain. - <c>transit</c>: Public transit routes (based on real-time data). - <c>approximated_transit</c>: Estimated public transit routes (without real-time data).  Selecting the appropriate travel mode helps generate an isoline that accurately reflects the time or distance accessible for the specified mode.</param>
    /// <param name="range">The range value for the isoline. For isochrones, the range is specified in seconds (travel time). For isodistances, it is specified in meters (travel distance).</param>
    /// <param name="avoid">Specifies road types or specific locations to avoid during routing. Use this to exclude features like toll roads, highways, ferries, or particular geographic areas.</param>
    /// <param name="traffic">The traffic model to be used in route calculations. The default value is <c>free_flow</c>, which does not consider real-time traffic. Alternatively, use <c>approximated</c> for a traffic-influenced model.</param>
    /// <param name="routeType">Defines the type of route to calculate. Options include <c>balanced</c> for a mix of efficiency and speed, <c>short</c> for the shortest route, and <c>less_maneuvers</c> to minimize turns or complexity. The default is <c>balanced</c>.</param>
    /// <param name="maxSpeed">The maximum speed that a vehicle can travel. This applies to driving mode, all truck modes, and bus modes. The max_speed should be specified within the range of 10 to 252 KPH (6.5 - 155 MPH). For trucks, the standard setting is 90 kilometers per hour (KPH), while for automobiles and buses, it's set at 140 KPH by default.</param>
    /// <param name="units">Specifies the units of measurement for distances in the response. The default is metric. Use <c>imperial</c> for miles, feet, etc.</param>
    /// <param name="id">ID of previously generated isoline. This parameter allows you to retrieve previously calculated isolines within a 24-hour window without recalculating them.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IsolineResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetIsolineError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns isolines (Isochrones or Isodistances) based on a specified location, travel mode, and range. Isochrones represent areas accessible within a given travel time, while isodistances represent areas reachable within a certain distance.
    /// </remarks>
    public Task<IsolineResponse> GetIsoline(string apiKey,
        double lat,
        double lon,
        Type5 type,
        Mode mode,
        string range,
        string? avoid,
        TrafficEnum? traffic,
        RouteTypeEnum? routeType,
        double? maxSpeed,
        UnitsEnum? units,
        string? id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/isoline"),
            [],
            [new Param("apiKey", apiKey),
                new Param("lat", lat),
                new Param("lon", lon),
                new Param("type", type),
                new Param("mode", mode),
                new Param("range", range),
                new Param("avoid", avoid),
                new Param("traffic", traffic),
                new Param("route_type", routeType),
                new Param("max_speed", maxSpeed),
                new Param("units", units),
                new Param("id", id)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IsolineResponse>(),
            GetIsolineErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
