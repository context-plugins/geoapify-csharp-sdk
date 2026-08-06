using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record AutocompleteJsonResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("results")]
    public IReadOnlyList<AutocompleteResult>? Results { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public AutocompleteQueryInfo? Query { get; init; }
}
