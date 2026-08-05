using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record MapmatchingRequest
{
    /// <summary>
    /// Specifies the transportation mode for matching the GPS coordinates to the road network. Different modes reflect the travel type and optimize the mapping accordingly. Available options include:
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
    ///   <item><description><c>mountain_bike</c>: Mountain bike, optimized for off-road cycling.</description></item>
    ///   <item><description><c>road_bike</c>: Road bicycle, optimized for paved roads.</description></item>
    ///   <item><description><c>walk</c>: Walking on foot.</description></item>
    ///   <item><description><c>hike</c>: Hiking on trails or rugged terrain.</description></item>
    ///   <item><description><c>transit</c>: Public transit routes (based on real-time data).</description></item>
    ///   <item><description><c>approximated_transit</c>: Estimated public transit routes without real-time data.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public string? Mode { get; init; }

    /// <summary>
    /// An array of waypoints to be matched to the road network. Each waypoint includes coordinates, a timestamp, and an optional bearing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("waypoints")]
    public IReadOnlyList<Waypoint>? Waypoints { get; init; }
}
