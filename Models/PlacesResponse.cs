using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record PlacesResponse
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("features")]
    public required IReadOnlyList<object> Features { get; init; }
}
