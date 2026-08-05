using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

/// <summary>
/// Route type used in calculation, Determines the type of route calculation optimization.
///   - <c>balanced</c>: Provides a route that balances speed and distance.
///   - <c>short</c>: Prioritizes the shortest distance.
///   - <c>less_maneuvers</c>: Minimizes the number of turns and maneuvers, useful for larger vehicles or easier navigation., Route type used in calculation
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
