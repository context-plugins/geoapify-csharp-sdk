using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Ipstate
{
    /// <summary>
    /// State or province name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
