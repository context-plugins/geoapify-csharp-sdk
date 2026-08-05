using System.Collections.Generic;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record RoutingGeoJsonFeature
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
    public RoutingResult1? Properties { get; init; }

    /// <summary>
    /// Feature geometry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public Geometry? Geometry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinates")]
    public IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>? Coordinates { get; init; }
}
