using System.Text.Json.Serialization;
using GeoapifyApi.Models.AnyOf;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

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
