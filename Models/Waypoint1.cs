using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Waypoint1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public IReadOnlyList<double>? Location { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_index")]
    public int? OriginalIndex { get; init; }
}
