using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record LatLonCoordinates
{
    /// <summary>
    /// Latitude coordinate of the location
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat")]
    public double? Lat { get; init; }

    /// <summary>
    /// Longitude coordinate of the location
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lon")]
    public double? Lon { get; init; }
}
