using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record AutocompleteGeoJsonFeature
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type1? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public AutocompleteResult? Properties { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public PointGeometry? Geometry { get; init; }

    /// <summary>
    /// Bounding box [lon1, lat1, lon2, lat2]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bbox")]
    [MinLength(4)]
    [MaxLength(4)]
    public IReadOnlyList<double>? Bbox { get; init; }
}
