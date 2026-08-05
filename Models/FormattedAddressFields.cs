using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record FormattedAddressFields
{
    /// <summary>
    /// Display address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formatted")]
    public string? Formatted { get; init; }

    /// <summary>
    /// Main part of the display address, contains building street and house number or amenity name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line1")]
    public string? AddressLine1 { get; init; }

    /// <summary>
    /// The second part of the display address, contains address parts not included to address_line1
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line2")]
    public string? AddressLine2 { get; init; }
}
