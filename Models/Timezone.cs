using System.Text.Json.Serialization;

namespace GeoapifyApi.Models;

public record Timezone
{
    /// <summary>
    /// Timezone name (e.g., Europe/Berlin)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The alternative name of the timezone, if exist
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name_alt")]
    public string? NameAlt { get; init; }

    /// <summary>
    /// Standard time offset (e.g., +01:00)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset_STD")]
    public string? OffsetStd { get; init; }

    /// <summary>
    /// Standard time offset in seconds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset_STD_seconds")]
    public int? OffsetStdSeconds { get; init; }

    /// <summary>
    /// Daylight saving time offset (e.g., +02:00)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset_DST")]
    public string? OffsetDst { get; init; }

    /// <summary>
    /// Daylight saving time offset in seconds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("offset_DST_seconds")]
    public int? OffsetDstSeconds { get; init; }

    /// <summary>
    /// Standard time abbreviation (e.g., CET)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("abbreviation_STD")]
    public string? AbbreviationStd { get; init; }

    /// <summary>
    /// Daylight saving time abbreviation (e.g., CEST)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("abbreviation_DST")]
    public string? AbbreviationDst { get; init; }
}
