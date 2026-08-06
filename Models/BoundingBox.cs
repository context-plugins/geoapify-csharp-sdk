using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record BoundingBox
{
    /// <summary>
    /// Minimum longitude
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lon1")]
    public double? Lon1 { get; init; }

    /// <summary>
    /// Minimum latitude
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat1")]
    public double? Lat1 { get; init; }

    /// <summary>
    /// Maximum longitude
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lon2")]
    public double? Lon2 { get; init; }

    /// <summary>
    /// Maximum latitude
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat2")]
    public double? Lat2 { get; init; }
}
