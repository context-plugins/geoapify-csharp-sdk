using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record GeoJsonFeature
{
    /// <summary>
    /// GeoJSON feature type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type1? Type { get; init; }

    /// <summary>
    /// Feature properties
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public object? Properties { get; init; }

    /// <summary>
    /// Feature geometry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public object? Geometry { get; init; }
}
