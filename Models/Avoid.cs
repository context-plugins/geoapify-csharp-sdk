using System.Collections.Generic;
using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record Avoid
{
    /// <summary>
    /// The type of feature to avoid, such as toll roads, highways, or specific geographic locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type4? Type { get; init; }

    /// <summary>
    /// Specifies the importance of avoiding the selected road type or location, with values ranging from 0 to 1. A value of <c>1</c> means the avoidance is critical, while a value of <c>0</c> means it is not important and can be ignored if necessary.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("importance")]
    public double? Importance { get; init; }

    /// <summary>
    /// List of coordinates to avoid if the avoid type is set to "locations". This is useful for bypassing specific geographic areas or obstacles (e.g., road closures or restricted areas).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<LatLonCoordinates>? Values { get; init; }
}
