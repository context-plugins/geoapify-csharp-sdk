using System.Text.Json.Serialization;
using Geoapify.Models.AnyOf;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record IsolineGeometry
{
    /// <summary>
    /// GeoJSON geometry type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type31? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinates")]
    public Coordinates? Coordinates { get; init; }
}
