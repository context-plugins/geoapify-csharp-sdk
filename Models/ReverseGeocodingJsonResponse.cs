using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record ReverseGeocodingJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public IReadOnlyList<ReverseGeocodingResult>? Results { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public ReverseQueryInfo? Query { get; init; }
}
