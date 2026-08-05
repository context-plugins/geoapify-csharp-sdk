using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Ipcity
{
    /// <summary>
    /// City names in different languages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public IReadOnlyDictionary<string, string>? Names { get; init; }

    /// <summary>
    /// City name in English
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
