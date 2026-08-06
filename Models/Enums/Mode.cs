using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Specifies the transportation mode to be used for route calculation. Choose from various options based on the vehicle or method of travel, including:
/// <list type="bullet">
///   <item><description><c>drive</c>: Standard car or automobile.</description></item>
///   <item><description><c>light_truck</c>: Light-duty truck.</description></item>
///   <item><description><c>medium_truck</c>: Medium-duty truck.</description></item>
///   <item><description><c>truck</c>: General truck.</description></item>
///   <item><description><c>heavy_truck</c>: Heavy-duty truck.</description></item>
///   <item><description><c>truck_dangerous_goods</c>: Truck carrying hazardous materials.</description></item>
///   <item><description><c>long_truck</c>: Long or articulated truck.</description></item>
///   <item><description><c>bus</c>: Public or private bus.</description></item>
///   <item><description><c>scooter</c>: Motorized scooter.</description></item>
///   <item><description><c>motorcycle</c>: Motorbike.</description></item>
///   <item><description><c>bicycle</c>: Standard bicycle.</description></item>
///   <item><description><c>mountain_bike</c>: Mountain bike, optimized for off-road travel.</description></item>
///   <item><description><c>road_bike</c>: Road bicycle, optimized for paved surfaces.</description></item>
///   <item><description><c>walk</c>: Walking on foot.</description></item>
///   <item><description><c>hike</c>: Hiking, often on rough terrain or trails.</description></item>
///   <item><description><c>transit</c>: Public transportation with real-time data.</description></item>
///   <item><description><c>approximated_transit</c>: Estimated public transportation routes without real-time data.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : StringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode Drive = new("drive");

    public static readonly Mode LightTruck = new("light_truck");

    public static readonly Mode MediumTruck = new("medium_truck");

    public static readonly Mode Truck = new("truck");

    public static readonly Mode HeavyTruck = new("heavy_truck");

    public static readonly Mode TruckDangerousGoods = new("truck_dangerous_goods");

    public static readonly Mode LongTruck = new("long_truck");

    public static readonly Mode Bus = new("bus");

    public static readonly Mode Scooter = new("scooter");

    public static readonly Mode Motorcycle = new("motorcycle");

    public static readonly Mode Bicycle = new("bicycle");

    public static readonly Mode MountainBike = new("mountain_bike");

    public static readonly Mode RoadBike = new("road_bike");

    public static readonly Mode Walk = new("walk");

    public static readonly Mode Hike = new("hike");

    public static readonly Mode Transit = new("transit");

    public static readonly Mode ApproximatedTransit = new("approximated_transit");

    public static Mode FromValue(string value) => FromValueCore(value);
}
