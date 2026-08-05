using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record AddressComponents
{
    /// <summary>
    /// Country component of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// ISO 3166-1 alpha-2 country code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// State component of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// State shortcode, the shortcode might be missing for some countries and languages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_code")]
    public string? StateCode { get; init; }

    /// <summary>
    /// City component of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>
    /// County component of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("county")]
    public string? County { get; init; }

    /// <summary>
    /// County shortcode, the shortcode might be missing for some countries and languages
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("county_code")]
    public string? CountyCode { get; init; }

    /// <summary>
    /// Postcode or ZIP code of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postcode")]
    public string? Postcode { get; init; }

    /// <summary>
    /// Street component of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("street")]
    public string? Street { get; init; }

    /// <summary>
    /// House number component of an address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("housenumber")]
    public string? Housenumber { get; init; }

    /// <summary>
    /// Suburb component of the address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suburb")]
    public string? Suburb { get; init; }

    /// <summary>
    /// District name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("district")]
    public string? District { get; init; }
}
