using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record MapMatchingProperties
{
    /// <summary>
    /// Distance in meters for the whole route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Time in seconds for the whole route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// Requested transportation or travel mode
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public string? Mode { get; init; }

    /// <summary>
    /// An array of MatchedWaypoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("waypoints")]
    public IReadOnlyList<MatchedWaypoint>? Waypoints { get; init; }

    /// <summary>
    /// An array of RouteLeg. Each leg represents separate parts of the route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legs")]
    public IReadOnlyList<RouteLeg>? Legs { get; init; }
}
