using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Route type used in calculation
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RouteTypeEnum>))]
public sealed record RouteTypeEnum : StringEnum<RouteTypeEnum>
{
    private RouteTypeEnum(string value) : base(value)
    {
    }

    public static readonly RouteTypeEnum Balanced = new("balanced");

    public static readonly RouteTypeEnum Short = new("short");

    public static readonly RouteTypeEnum LessManeuvers = new("less_maneuvers");

    public static RouteTypeEnum FromValue(string value) => FromValueCore(value);
}
