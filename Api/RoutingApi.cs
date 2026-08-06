using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GeoapifyApi.Core;
using GeoapifyApi.Core.Exceptions;
using GeoapifyApi.Core.Models;
using GeoapifyApi.Core.Request;
using GeoapifyApi.Core.Response;
using GeoapifyApi.Errors;
using GeoapifyApi.Models.AnyOf;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Api;

/// <summary>
/// Provides route calculations for various transportation modes, including automobiles, trucks, bicycles, and walking.
/// </summary>
public sealed class RoutingApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal RoutingApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Calculate a route between waypoints
    /// </summary>
    /// <param name="apiKey">Your Geoapify API key to authenticate the request. You can sign up and obtain an API key for free at <see href="https://myprojects.geoapify.com/">https://myprojects.geoapify.com/</see>. The Free plan includes up to 3,000 requests per day.</param>
    /// <param name="waypoints">A list of coordinates representing the waypoints for the route. Each coordinate is specified as a latitude, longitude pair.   Multiple waypoints should be separated by a vertical bar (<c>|</c>). At least two waypoints (a start and an endpoint) are required, but additional waypoints can be added to customize the route.   Example format:  "50.679023,4.569876|50.661705,4.578667"</param>
    /// <param name="mode">Specifies how the route will be optimized based on the selected transportation type.  Available options include: - <c>drive</c>: Standard car or automobile. - <c>light_truck</c>: Light-duty truck. - <c>medium_truck</c>: Medium-duty truck. - <c>truck</c>: General truck. - <c>heavy_truck</c>: Heavy-duty truck. - <c>truck_dangerous_goods</c>: Truck carrying dangerous goods. - <c>long_truck</c>: Long or articulated truck. - <c>bus</c>: Public or private bus. - <c>scooter</c>: Motorized scooter. - <c>motorcycle</c>: Motorbike. - <c>bicycle</c>: Standard bicycle. - <c>mountain_bike</c>: Mountain bike. - <c>road_bike</c>: Road bicycle. - <c>walk</c>: Walking on foot. - <c>hike</c>: Hiking on trails or difficult terrain. - <c>transit</c>: Public transit routes. - <c>approximated_transit</c>: Estimated public transit routes (without real-time data).  Choose the appropriate mode for more accurate route calculations.</param>
    /// <param name="type">Specifies the type of route optimization to apply. This parameter determines how the route will be optimized based on user preferences:  - <c>balanced</c>: Provides a balanced route, optimizing for both travel time and distance. - <c>short</c>: Prioritizes the shortest possible route in terms of distance, potentially ignoring other factors like travel time. - <c>less_maneuvers</c>: Reduces the number of turns or complex maneuvers, providing a simpler route, which can be useful for larger vehicles or ease of navigation.</param>
    /// <param name="units">Specifies the units of measurement for distance in the response. Choose between:  - <c>metric</c>: Uses kilometers and meters. - <c>imperial</c>: Uses miles and feet.  If not specified, the default is <c>metric</c>. Select the appropriate units based on the region or user preferences.</param>
    /// <param name="lang">Result language in <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> format (e.g., 'en' for English).</param>
    /// <param name="avoid">Specifies the types of roads or locations to avoid during route calculation. You can customize this option by adding one or more types, separated by a vertical bar (<c>|</c>), and even assign importance to some avoid types on a scale from 0 to 1.  Available options include:  - <b>tolls</b>: Avoid roads with tolls. You can specify importance as <c>tolls:importance</c>, where <c>importance</c> is a value between 0 and 1 (with 1 being the most important). This option works with modes like <c>drive</c>, <c>truck</c>, <c>light_truck</c>, <c>medium_truck</c>, <c>truck_dangerous_goods</c>, <c>heavy_truck</c>, <c>long_truck</c>, and <c>bus</c>.   - Example: <c>avoid=tolls</c> or <c>avoid=tolls:0.8</c>  - <b>ferries</b>: Avoid routes that include ferries. You can specify importance as <c>ferries:importance</c> (similar to tolls).    - Example: <c>avoid=ferries</c> or <c>avoid=ferries:0.9</c>  - <b>highways</b>: Avoid highways. You can also specify importance as <c>highways:importance</c>. This option works with driving-related modes.   - Example: <c>avoid=highways</c> or <c>avoid=highways:0.7</c>  - <b>location</b>: Avoid specific geographic locations. You can provide a latitude and longitude pair in the format <c>location:lat,lon</c> or <c>location_lonlat:lon,lat</c> to avoid certain areas (e.g., closed roads or barriers).   - Example: <c>avoid=location:35.234045,-80.836392</c> or <c>avoid=location_lonlat:-80.836392,35.234045</c>  Note: The routing algorithm will take your avoids into account but may still include them if there are no alternative routes. Using the <c>avoid</c> parameter may increase calculation time and add extra cost to the API call.</param>
    /// <param name="details">Specifies additional details to include in the response. You can request multiple types of information, separated by commas. Available options include:  - <c>instruction_details</c>: Provides more granular step-by-step navigation instructions. - <c>route_details</c>: Includes detailed information about the route, such as distances and durations for each segment. - <c>elevation</c>: Adds elevation data along the route, showing the changes in altitude.  You can combine these options as needed to get more comprehensive routing information.</param>
    /// <param name="traffic">Specifies the traffic model to use during route calculation. The available options are:  - <c>free_flow</c>: The default option. Calculates the route optimistically, assuming no traffic delays or congestion. - <c>approximated</c>: Adjusts the route by accounting for potential traffic, decreasing speed on roads that are likely to be congested.  This parameter is only applicable to motorized vehicle modes, such as <c>drive</c>, <c>truck</c>, and other similar modes.</param>
    /// <param name="maxSpeed">The maximum allowable speed for the route, specified in kilometers per hour (KPH).</param>
    /// <param name="format">The desired output format for the response, options include 'geojson', 'json', or 'xml'.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RoutingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CalculateRouteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculates the optimal route between two or more waypoints for various transportation modes, including cars, trucks, bicycles, and walking. The API allows customization through parameters such as road type avoidance (e.g., tolls, highways) and specific route preferences (e.g., shortest or fastest). The response includes detailed directions and turn-by-turn navigation for seamless travel planning.
    /// </remarks>
    public Task<RoutingResponse> CalculateRoute(string apiKey,
        string waypoints,
        Mode mode,
        RouteTypeEnum? type,
        UnitsEnum? units,
        string? lang,
        string? avoid,
        string? details,
        TrafficEnum? traffic,
        int? maxSpeed,
        Format? format,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/routing"),
            [],
            [new Param("apiKey", apiKey),
                new Param("waypoints", waypoints),
                new Param("mode", mode),
                new Param("type", type),
                new Param("units", units),
                new Param("lang", lang),
                new Param("avoid", avoid),
                new Param("details", details),
                new Param("traffic", traffic),
                new Param("max_speed", maxSpeed),
                new Param("format", format)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RoutingResponse>(),
            CalculateRouteErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
