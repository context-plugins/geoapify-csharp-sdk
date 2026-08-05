using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record ReverseQueryInfo
{
    /// <summary>
    /// Query latitude
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat")]
    public double? Lat { get; init; }

    /// <summary>
    /// Query longitude
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lon")]
    public double? Lon { get; init; }

    /// <summary>
    /// Plus code for the query coordinates
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plus_code")]
    public string? PlusCode { get; init; }
}
