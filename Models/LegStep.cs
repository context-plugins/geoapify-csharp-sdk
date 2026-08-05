using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record LegStep
{
    /// <summary>
    /// Route step name. Usually a street name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Road class. Possible values unclassified, motorway, trunk, primary, secondary, tertiary, unclassified, residential, service_other
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("road_class")]
    public RoadClass? RoadClass { get; init; }

    /// <summary>
    /// Type of surface. Possible values paved_smooth, paved, paved_rough, compacted, dirt, gravel, path, impassable
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surface")]
    public Surface? Surface { get; init; }

    /// <summary>
    /// Traversability of the road segment. Possible values forward, backward, both
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traversability")]
    public Traversability? Traversability { get; init; }

    /// <summary>
    /// Actual (calculated) speed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speed")]
    public double? Speed { get; init; }

    /// <summary>
    /// Speed limit for the road segment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speed_limit")]
    public double? SpeedLimit { get; init; }

    /// <summary>
    /// Number of lanes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lane_count")]
    public int? LaneCount { get; init; }

    /// <summary>
    /// Indicates whether the step is a part of a toll route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("toll")]
    public bool? Toll { get; init; }

    /// <summary>
    /// Indicates whether the step is a part of a tunnel
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tunnel")]
    public bool? Tunnel { get; init; }

    /// <summary>
    /// Indicates whether the step is a part of a bridge
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bridge")]
    public bool? Bridge { get; init; }

    /// <summary>
    /// Time in seconds required to pass the road segment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// Length of the route segment in meters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Starting bearing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_bearing")]
    public double? BeginBearing { get; init; }

    /// <summary>
    /// Final bearing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_bearing")]
    public double? EndBearing { get; init; }

    /// <summary>
    /// An index of the starting point for the segment in the corresponding feature coordinates array
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_index")]
    public int? FromIndex { get; init; }

    /// <summary>
    /// An index of the end point for the segment in the corresponding feature coordinates array
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("to_index")]
    public int? ToIndex { get; init; }

    /// <summary>
    /// OpenStreetMap way id. You can get additional route parameters from the OSM database by using the id parameter. Note that the OpenStreetMap ID is not static and may be changed in the future
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("osm_way_id")]
    public int? OsmWayId { get; init; }

    /// <summary>
    /// Indicates whether the step is a part of a roundabout
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roundabout")]
    public bool? Roundabout { get; init; }
}
