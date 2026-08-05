using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record RoutingStep
{
    /// <summary>
    /// Distance of the route segment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Estimated travel time in seconds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// Index where geometry starts in the leg geometry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_index")]
    public int? FromIndex { get; init; }

    /// <summary>
    /// Index where geometry ends in the leg geometry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("to_index")]
    public int? ToIndex { get; init; }

    /// <summary>
    /// True if the step has toll
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("toll")]
    public bool? Toll { get; init; }

    /// <summary>
    /// True if includes a ferry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ferry")]
    public bool? Ferry { get; init; }

    /// <summary>
    /// True if is a tunnel
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tunnel")]
    public bool? Tunnel { get; init; }

    /// <summary>
    /// True if is a bridge
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bridge")]
    public bool? Bridge { get; init; }

    /// <summary>
    /// True if is a roundabout
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roundabout")]
    public bool? Roundabout { get; init; }

    /// <summary>
    /// Estimated speed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speed")]
    public double? Speed { get; init; }

    /// <summary>
    /// Speed limit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speed_limit")]
    public double? SpeedLimit { get; init; }

    /// <summary>
    /// Speed limit for trucks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("truck_limit")]
    public double? TruckLimit { get; init; }

    /// <summary>
    /// Road surface type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surface")]
    public Surface? Surface { get; init; }

    /// <summary>
    /// Number of lanes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lane_count")]
    public int? LaneCount { get; init; }

    /// <summary>
    /// Road class
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("road_class")]
    public RoadClass? RoadClass { get; init; }

    /// <summary>
    /// Road name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// True for driving on the right side
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rightside")]
    public bool? Rightside { get; init; }

    /// <summary>
    /// Traversability direction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traversability")]
    public Traversability? Traversability { get; init; }

    /// <summary>
    /// Average elevation along the step
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("elevation")]
    public double? Elevation { get; init; }

    /// <summary>
    /// Maximal elevation along the step
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_elevation")]
    public double? MaxElevation { get; init; }

    /// <summary>
    /// Minimal elevation along the step
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_elevation")]
    public double? MinElevation { get; init; }

    /// <summary>
    /// Elevation difference between first and last point
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("elevation_gain")]
    public double? ElevationGain { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instruction")]
    public RoutingInstruction? Instruction { get; init; }
}
