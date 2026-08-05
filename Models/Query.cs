using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Query
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parsed")]
    public Parsed1? Parsed { get; init; }
}
