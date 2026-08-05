using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Parsed1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_type")]
    public string? ExpectedType { get; init; }
}
