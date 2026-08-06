using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record ReverseGeoJsonFeature
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type1? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public ReverseGeocodingResult? Properties { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public AutocompleteGeometry? Geometry { get; init; }

    /// <summary>
    /// Bounding box [lon1, lat1, lon2, lat2]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bbox")]
    [MinLength(4)]
    [MaxLength(4)]
    public IReadOnlyList<double>? Bbox { get; init; }
}
