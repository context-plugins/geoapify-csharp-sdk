using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record RouteMatrixResponse
{
    /// <summary>
    /// List of from-waypoints with original and matched to existing roads locations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sources")]
    public IReadOnlyList<RouteMatrixLocation>? Sources { get; init; }

    /// <summary>
    /// List of to-waypoints with original and matched to existing roads locations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targets")]
    public IReadOnlyList<RouteMatrixLocation>? Targets { get; init; }

    /// <summary>
    /// The time-distance matrix as a 2D array
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sources_to_targets")]
    public IReadOnlyList<IReadOnlyList<RouteMatrixEntry>>? SourcesToTargets { get; init; }
}
