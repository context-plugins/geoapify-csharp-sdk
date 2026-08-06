using System.Collections.Generic;
using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record RoutematrixRequest
{
    /// <summary>
    /// Specifies the transportation mode to be used for route calculation. Choose from various options based on the vehicle or method of travel, including:
    /// <list type="bullet">
    ///   <item><description><c>drive</c>: Standard car or automobile.</description></item>
    ///   <item><description><c>light_truck</c>: Light-duty truck.</description></item>
    ///   <item><description><c>medium_truck</c>: Medium-duty truck.</description></item>
    ///   <item><description><c>truck</c>: General truck.</description></item>
    ///   <item><description><c>heavy_truck</c>: Heavy-duty truck.</description></item>
    ///   <item><description><c>truck_dangerous_goods</c>: Truck carrying hazardous materials.</description></item>
    ///   <item><description><c>long_truck</c>: Long or articulated truck.</description></item>
    ///   <item><description><c>bus</c>: Public or private bus.</description></item>
    ///   <item><description><c>scooter</c>: Motorized scooter.</description></item>
    ///   <item><description><c>motorcycle</c>: Motorbike.</description></item>
    ///   <item><description><c>bicycle</c>: Standard bicycle.</description></item>
    ///   <item><description><c>mountain_bike</c>: Mountain bike, optimized for off-road travel.</description></item>
    ///   <item><description><c>road_bike</c>: Road bicycle, optimized for paved surfaces.</description></item>
    ///   <item><description><c>walk</c>: Walking on foot.</description></item>
    ///   <item><description><c>hike</c>: Hiking, often on rough terrain or trails.</description></item>
    ///   <item><description><c>transit</c>: Public transportation with real-time data.</description></item>
    ///   <item><description><c>approximated_transit</c>: Estimated public transportation routes without real-time data.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public Mode? Mode { get; init; }

    /// <summary>
    /// List of source waypoints, where each waypoint is defined by a pair of latitude and longitude coordinates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sources")]
    public IReadOnlyList<Source>? Sources { get; init; }

    /// <summary>
    /// List of target waypoints, where each target is defined by a pair of longitude and latitude coordinates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targets")]
    public IReadOnlyList<Target>? Targets { get; init; }

    /// <summary>
    /// A list of road types or specific locations to avoid during route calculation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avoid")]
    public IReadOnlyList<Avoid>? Avoid { get; init; }

    /// <summary>
    /// Specifies the traffic model to use for route calculation.
    ///   - <c>free_flow</c>: Assumes no traffic and calculates the route based on optimal conditions.
    ///   - <c>approximated</c>: Takes potential traffic into account, adjusting travel speeds on congested roads.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traffic")]
    public TrafficEnum? Traffic { get; init; }

    /// <summary>
    /// Determines the type of route calculation optimization.
    ///   - <c>balanced</c>: Provides a route that balances speed and distance.
    ///   - <c>short</c>: Prioritizes the shortest distance.
    ///   - <c>less_maneuvers</c>: Minimizes the number of turns and maneuvers, useful for larger vehicles or easier navigation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public RouteTypeEnum? Type { get; init; }

    /// <summary>
    /// Maximum allowable speed for the route, specified in kilometers per hour (KPH). This is typically used for vehicle-based modes of transportation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_speed")]
    public double? MaxSpeed { get; init; }

    /// <summary>
    /// Specifies the unit system to use for measuring distances in the response.
    ///   - <c>metric</c>: Uses kilometers and meters.
    ///   - <c>imperial</c>: Uses miles and feet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("units")]
    public UnitsEnum? Units { get; init; }
}
