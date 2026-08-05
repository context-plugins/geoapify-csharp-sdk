using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

/// <summary>
/// Traffic model used in calculation, Specifies the traffic model to use for route calculation.
///   - <c>free_flow</c>: Assumes no traffic and calculates the route based on optimal conditions.
///   - <c>approximated</c>: Takes potential traffic into account, adjusting travel speeds on congested roads., Traffic model used in calculation
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
