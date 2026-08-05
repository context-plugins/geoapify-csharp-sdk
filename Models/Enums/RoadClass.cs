using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

/// <summary>
/// Road class. Possible values unclassified, motorway, trunk, primary, secondary, tertiary, unclassified, residential, service_other, Road class
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RoadClass>))]
public sealed record RoadClass : StringEnum<RoadClass>
{
    private RoadClass(string value) : base(value)
    {
    }

    public static readonly RoadClass Unclassified = new("unclassified");

    public static readonly RoadClass Motorway = new("motorway");

    public static readonly RoadClass Trunk = new("trunk");

    public static readonly RoadClass Primary = new("primary");

    public static readonly RoadClass Secondary = new("secondary");

    public static readonly RoadClass Tertiary = new("tertiary");

    public static readonly RoadClass Residential = new("residential");

    public static readonly RoadClass ServiceOther = new("service_other");

    public static RoadClass FromValue(string value) => FromValueCore(value);
}
