using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Iplanguage
{
    /// <summary>
    /// ISO 639-1 language code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_code")]
    public string? IsoCode { get; init; }

    /// <summary>
    /// Language name in English
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Language name in native script
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name_native")]
    public string? NameNative { get; init; }
}
