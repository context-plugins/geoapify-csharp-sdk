using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record RouteMatrixLocation
{
    /// <summary>
    /// Coordinates as [longitude, latitude]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_location")]
    [MinLength(2)]
    [MaxLength(2)]
    public IReadOnlyList<double>? OriginalLocation { get; init; }

    /// <summary>
    /// Coordinates as [longitude, latitude]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    [MinLength(2)]
    [MaxLength(2)]
    public IReadOnlyList<double>? Location { get; init; }
}
