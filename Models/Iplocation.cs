using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Iplocation
{
    /// <summary>
    /// Latitude coordinate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latitude")]
    public double? Latitude { get; init; }

    /// <summary>
    /// Longitude coordinate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("longitude")]
    public double? Longitude { get; init; }
}
