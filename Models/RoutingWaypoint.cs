using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record RoutingWaypoint
{
    /// <summary>
    /// Coordinates as [longitude, latitude]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    [MinLength(2)]
    [MaxLength(2)]
    public IReadOnlyList<double>? Location { get; init; }

    /// <summary>
    /// Original index of the waypoint
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_index")]
    public int? OriginalIndex { get; init; }
}
