using System.Collections.Generic;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record MapMatchingGeometry
{
    /// <summary>
    /// GeoJSON geometry type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type22? Type { get; init; }

    /// <summary>
    /// MultiLineString coordinates representing the matched route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinates")]
    public IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>? Coordinates { get; init; }
}
