using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Matched type. Possible values matched, unmatched, interpolated
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MatchType>))]
public sealed record MatchType : StringEnum<MatchType>
{
    private MatchType(string value) : base(value)
    {
    }

    public static readonly MatchType Matched = new("matched");

    public static readonly MatchType Unmatched = new("unmatched");

    public static readonly MatchType Interpolated = new("interpolated");

    public static MatchType FromValue(string value) => FromValueCore(value);
}
