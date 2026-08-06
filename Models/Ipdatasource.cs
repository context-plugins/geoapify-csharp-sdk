using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Ipdatasource
{
    /// <summary>
    /// Name of the data source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Attribution text (may contain HTML)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attribution")]
    public string? Attribution { get; init; }

    /// <summary>
    /// License name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("license")]
    public string? License { get; init; }
}
