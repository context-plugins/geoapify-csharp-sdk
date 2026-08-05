using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record RoutingProperties
{
    /// <summary>
    /// Transportation mode
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public string? Mode { get; init; }

    /// <summary>
    /// Original waypoints coordinates
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("waypoints")]
    public IReadOnlyList<IReadOnlyList<double>>? Waypoints { get; init; }

    /// <summary>
    /// Distance units
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("units")]
    public string? Units { get; init; }

    /// <summary>
    /// Avoided road types or locations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avoid")]
    public IReadOnlyList<string>? Avoid { get; init; }

    /// <summary>
    /// Additional details requested
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<string>? Details { get; init; }

    /// <summary>
    /// Traffic model used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traffic")]
    public string? Traffic { get; init; }
}
