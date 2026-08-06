using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Properties
{
    /// <summary>
    /// Unique identifier that can be used to retrieve the isoline data later
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
