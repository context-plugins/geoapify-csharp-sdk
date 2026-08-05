using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Ipcountry
{
    /// <summary>
    /// GeoNames database identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geoname_id")]
    public int? GeonameId { get; init; }

    /// <summary>
    /// ISO 3166-1 alpha-2 country code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iso_code")]
    public string? IsoCode { get; init; }

    /// <summary>
    /// Country names in different languages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public IReadOnlyDictionary<string, string>? Names { get; init; }

    /// <summary>
    /// Country name in English
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Country name in native language
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name_native")]
    public string? NameNative { get; init; }

    /// <summary>
    /// International dialing code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_code")]
    public string? PhoneCode { get; init; }

    /// <summary>
    /// Capital city name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capital")]
    public string? Capital { get; init; }

    /// <summary>
    /// Currency codes (comma-separated if multiple)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// Country flag emoji
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flag")]
    public string? Flag { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("languages")]
    public IReadOnlyList<Iplanguage>? Languages { get; init; }
}
