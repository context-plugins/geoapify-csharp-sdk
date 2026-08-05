using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record RouteMatrixEntry
{
    /// <summary>
    /// Distance in meters between source waypoint and target waypoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Travel time in seconds between source waypoint and target waypoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// Index of the source waypoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_index")]
    public int? SourceIndex { get; init; }

    /// <summary>
    /// Index of the target waypoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target_index")]
    public int? TargetIndex { get; init; }
}
