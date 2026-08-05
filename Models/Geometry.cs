using System.Text.Json.Serialization;
using Geoapify.Models.Enums;

namespace Geoapify.Models;

/// <summary>
/// Feature geometry
/// </summary>
public record Geometry
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type22? Type { get; init; }
}
