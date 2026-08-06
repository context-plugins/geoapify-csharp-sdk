using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Target
{
    /// <summary>
    /// Coordinates of the target location, represented as [longitude, latitude].
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public IReadOnlyList<double>? Location { get; init; }
}
