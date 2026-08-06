using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record IsolineResponseProperties
{
    /// <summary>
    /// Unique identifier for the isoline calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
