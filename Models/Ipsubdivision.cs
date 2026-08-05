using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Ipsubdivision
{
    /// <summary>
    /// Subdivision names in different languages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public IReadOnlyDictionary<string, string>? Names { get; init; }
}
