using System.Collections.Generic;
using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record IsolineResponse
{
    /// <summary>
    /// GeoJSON object type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; init; }

    /// <summary>
    /// Array of GeoJSON features
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("features")]
    public IReadOnlyList<IsolineFeature>? Features { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public IsolineResponseProperties? Properties { get; init; }
}
