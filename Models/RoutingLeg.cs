using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Geoapify.Models;

public record RoutingLeg
{
    /// <summary>
    /// Distance of the route leg
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Estimated travel time in seconds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// Array of steps in this leg
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("steps")]
    public IReadOnlyList<RoutingStep>? Steps { get; init; }

    /// <summary>
    /// Array of heights in meters (when elevation details requested)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("elevation")]
    public IReadOnlyList<double>? Elevation { get; init; }

    /// <summary>
    /// Array of [distance, height] values in meters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("elevation_range")]
    public IReadOnlyList<IReadOnlyList<double>>? ElevationRange { get; init; }

    /// <summary>
    /// List of country codes crossed by the route leg
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country_code")]
    public IReadOnlyList<string>? CountryCode { get; init; }
}
