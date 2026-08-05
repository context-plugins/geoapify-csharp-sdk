using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record Rank
{
    /// <summary>
    /// Confidence value, takes values from 0 to 1
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence")]
    public double? Confidence { get; init; }

    /// <summary>
    /// City-level confidence, takes values from 0 to 1. Evaluates if the city is correct
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_city_level")]
    public double? ConfidenceCityLevel { get; init; }

    /// <summary>
    /// Street-level confidence, takes values from 0 to 1. Evaluates if the street is correct
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_street_level")]
    public double? ConfidenceStreetLevel { get; init; }

    /// <summary>
    /// Building-level confidence, takes values from 0 to 1. Evaluates if the building position is correct
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_building_level")]
    public double? ConfidenceBuildingLevel { get; init; }

    /// <summary>
    /// Match type between requested address and result address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("match_type")]
    public string? MatchType { get; init; }
}
