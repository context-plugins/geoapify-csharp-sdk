using System.Collections.Generic;
using System.Text.Json.Serialization;
using GeoapifyApi.Models.Enums;

namespace GeoapifyApi.Models;

public record RoutingInstruction
{
    /// <summary>
    /// Navigation instruction text
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    /// <summary>
    /// Type of maneuver
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type6? Type { get; init; }

    /// <summary>
    /// Transition instruction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transition_instruction")]
    public string? TransitionInstruction { get; init; }

    /// <summary>
    /// Instruction before transition
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_transition_instruction")]
    public string? PreTransitionInstruction { get; init; }

    /// <summary>
    /// Instruction after transition
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("post_transition_instruction")]
    public string? PostTransitionInstruction { get; init; }

    /// <summary>
    /// List of street names for the maneuver
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streets")]
    public IReadOnlyList<string>? Streets { get; init; }

    /// <summary>
    /// List of exit numbers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exitNumber")]
    public IReadOnlyList<string>? ExitNumber { get; init; }

    /// <summary>
    /// List of exit road names
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exitRoadName")]
    public IReadOnlyList<string>? ExitRoadName { get; init; }

    /// <summary>
    /// List of exit directions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exitTowards")]
    public IReadOnlyList<string>? ExitTowards { get; init; }

    /// <summary>
    /// True when transition instruction contains part of next instruction
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contains_next_instruction")]
    public bool? ContainsNextInstruction { get; init; }

    /// <summary>
    /// Roundabout exit number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roundabout_exit")]
    public int? RoundaboutExit { get; init; }
}
