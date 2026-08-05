using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record PointGeometry
{
    /// <summary>
    /// GeoJSON geometry type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type2? Type { get; init; }

    /// <summary>
    /// Coordinates as [longitude, latitude]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinates")]
    [MinLength(2)]
    [MaxLength(2)]
    public IReadOnlyList<double>? Coordinates { get; init; }
}
