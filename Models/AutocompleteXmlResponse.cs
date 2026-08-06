using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record AutocompleteXmlResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public IReadOnlyList<Result>? Results { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public Query? Query { get; init; }
}
