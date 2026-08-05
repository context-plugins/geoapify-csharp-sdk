using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record RouteLeg
{
    /// <summary>
    /// Length of the route in meters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Time in seconds for the route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// An array of LegStep. Steps of the route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("steps")]
    public IReadOnlyList<LegStep>? Steps { get; init; }
}
