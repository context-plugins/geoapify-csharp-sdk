using System.Collections.Generic;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

/// <summary>
/// Feature properties
/// </summary>
public record IsolineFeatureProperties1
{
    /// <summary>
    /// Latitude of the location
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lat")]
    public double? Lat { get; init; }

    /// <summary>
    /// Longitude of the location
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lon")]
    public double? Lon { get; init; }

    /// <summary>
    /// Isoline type (isochrone or isodistance)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type21? Type { get; init; }

    /// <summary>
    /// Travel type used for calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public string? Mode { get; init; }

    /// <summary>
    /// The isoline range value (time in seconds or distance in meters)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("range")]
    public double? Range { get; init; }

    /// <summary>
    /// Array of the avoided road types and locations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avoid")]
    public IReadOnlyList<string>? Avoid { get; init; }

    /// <summary>
    /// Traffic model used in calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traffic")]
    public TrafficEnum? Traffic { get; init; }

    /// <summary>
    /// Route type used in calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("route_type")]
    public RouteTypeEnum? RouteType { get; init; }

    /// <summary>
    /// Distance units used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("units")]
    public UnitsEnum? Units { get; init; }

    /// <summary>
    /// Maximum speed setting used in calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_speed")]
    public double? MaxSpeed { get; init; }

    /// <summary>
    /// Isoline unique identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
