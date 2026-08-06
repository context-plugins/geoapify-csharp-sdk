using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Waypoint
{
    /// <summary>
    /// The coordinates of the waypoint in [longitude, latitude] format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public IReadOnlyList<double>? Location { get; init; }

    /// <summary>
    /// The timestamp of the waypoint in ISO 8601 format, indicating the precise time when the waypoint was recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }

    /// <summary>
    /// The bearing (in degrees) of the waypoint, indicating the compass direction of travel, ranging from 0 to 360 degrees.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bearing")]
    public double? Bearing { get; init; }
}
