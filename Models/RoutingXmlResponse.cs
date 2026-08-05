using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record RoutingXmlResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public IReadOnlyList<Result2>? Results { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public Properties1? Properties { get; init; }
}
