using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Traffic model used in calculation
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrafficEnum>))]
public sealed record TrafficEnum : StringEnum<TrafficEnum>
{
    private TrafficEnum(string value) : base(value)
    {
    }

    public static readonly TrafficEnum FreeFlow = new("free_flow");

    public static readonly TrafficEnum Approximated = new("approximated");

    public static TrafficEnum FromValue(string value) => FromValueCore(value);
}
