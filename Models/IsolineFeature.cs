using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record IsolineFeature
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
    public IsolineFeatureProperties1? Properties { get; init; }

    /// <summary>
    /// Feature geometry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public IsolineGeometry1? Geometry { get; init; }
}
