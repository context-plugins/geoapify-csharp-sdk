using System.Collections.Generic;
using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record RoutingResult
{
    /// <summary>
    /// Transportation mode used for routing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mode")]
    public string? Mode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("waypoints")]
    public IReadOnlyList<RoutingWaypoint>? Waypoints { get; init; }

    /// <summary>
    /// Distance units used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("units")]
    public UnitsEnum? Units { get; init; }

    /// <summary>
    /// List of avoided road types or locations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avoid")]
    public IReadOnlyList<RoutingAvoid>? Avoid { get; init; }

    /// <summary>
    /// Additional details requested
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<string>? Details { get; init; }

    /// <summary>
    /// Traffic model used in calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traffic")]
    public TrafficEnum? Traffic { get; init; }

    /// <summary>
    /// Total route distance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance")]
    public double? Distance { get; init; }

    /// <summary>
    /// Distance units (Miles or Meters)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("distance_units")]
    public string? DistanceUnits { get; init; }

    /// <summary>
    /// Estimated travel time in seconds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time")]
    public double? Time { get; init; }

    /// <summary>
    /// Maximum speed setting for the route
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_speed")]
    public double? MaxSpeed { get; init; }

    /// <summary>
    /// True if the route has tolls
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("toll")]
    public bool? Toll { get; init; }

    /// <summary>
    /// True if the route uses a ferry
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ferry")]
    public bool? Ferry { get; init; }

    /// <summary>
    /// Array of route legs between waypoints
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legs")]
    public IReadOnlyList<RoutingLeg>? Legs { get; init; }

    /// <summary>
    /// Route geometry as MultiLineString coordinates
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geometry")]
    public IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>? Geometry { get; init; }
}
