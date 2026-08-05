using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

public record MatchedWaypoint
{
    /// <summary>
    /// Original index of the waypoint in request
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_index")]
    public int? OriginalIndex { get; init; }

    /// <summary>
    /// Matched location. An array of the coordinates [lon, lat]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    [MinLength(2)]
    [MaxLength(2)]
    public IReadOnlyList<double>? Location { get; init; }

    /// <summary>
    /// Original location. An array of the coordinates [lon, lat]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_location")]
    [MinLength(2)]
    [MaxLength(2)]
    public IReadOnlyList<double>? OriginalLocation { get; init; }

    /// <summary>
    /// Matched type. Possible values matched, unmatched, interpolated
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("match_type")]
    public MatchType? MatchType { get; init; }

    /// <summary>
    /// Distance in meters between matched and original locations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("match_distance")]
    public double? MatchDistance { get; init; }

    /// <summary>
    /// Leg index, the waypoint belongs to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leg_index")]
    public int? LegIndex { get; init; }

    /// <summary>
    /// Step point, the waypoint belongs to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("step_index")]
    public int? StepIndex { get; init; }
}
