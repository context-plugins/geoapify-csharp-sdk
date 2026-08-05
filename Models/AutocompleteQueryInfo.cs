using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record AutocompleteQueryInfo
{
    /// <summary>
    /// Original query text
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    /// <summary>
    /// Parsed query components
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parsed")]
    public Parsed? Parsed { get; init; }
}
