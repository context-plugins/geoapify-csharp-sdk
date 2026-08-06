using System.Text.Json.Serialization;
using GeoapifyApi.Core.Validation;
using GeoapifyApi.Core.Validation.Attributes;

namespace GeoapifyApi.Models;

public record Datasource
{
    /// <summary>
    /// Name of the data source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourcename")]
    public string? Sourcename { get; init; }

    /// <summary>
    /// Attribution text
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

    /// <summary>
    /// URL to license or source
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public string? Url { get; init; }
}
