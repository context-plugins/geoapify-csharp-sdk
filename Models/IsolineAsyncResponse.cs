using System.Collections.Generic;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record IsolineAsyncResponse
{
    /// <summary>
    /// GeoJSON object type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; init; }

    /// <summary>
    /// Empty array when calculation is still in progress
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("features")]
    public IReadOnlyList<object>? Features { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public Properties? Properties { get; init; }
}
