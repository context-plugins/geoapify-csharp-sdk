using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record RoutingAvoid
{
    /// <summary>
    /// Type of road or location to avoid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Importance level from 0 to 1 (optional)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("importance")]
    public double? Importance { get; init; }
}
