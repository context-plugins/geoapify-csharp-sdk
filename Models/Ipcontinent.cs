using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Ipcontinent
{
    /// <summary>
    /// Two-letter continent code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// GeoNames database identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geoname_id")]
    public int? GeonameId { get; init; }

    /// <summary>
    /// Continent names in different languages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public IReadOnlyDictionary<string, string>? Names { get; init; }

    /// <summary>
    /// Continent name in English
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
