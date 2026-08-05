using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

/// <summary>
/// Traversability of the road segment. Possible values forward, backward, both, Traversability direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Traversability>))]
public sealed record Traversability : StringEnum<Traversability>
{
    private Traversability(string value) : base(value)
    {
    }

    public static readonly Traversability Forward = new("forward");

    public static readonly Traversability Backward = new("backward");

    public static readonly Traversability Both = new("both");

    public static Traversability FromValue(string value) => FromValueCore(value);
}
