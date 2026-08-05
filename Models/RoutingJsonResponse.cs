using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record RoutingJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public IReadOnlyList<RoutingResult>? Results { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public RoutingProperties? Properties { get; init; }
}
