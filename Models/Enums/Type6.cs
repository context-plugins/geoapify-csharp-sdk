using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

/// <summary>
/// Type of maneuver
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : StringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 None = new("None");

    public static readonly Type6 StartAt = new("StartAt");

    public static readonly Type6 StartAtRight = new("StartAtRight");

    public static readonly Type6 StartAtLeft = new("StartAtLeft");

    public static readonly Type6 DestinationReached = new("DestinationReached");

    public static readonly Type6 DestinationReachedRight = new("DestinationReachedRight");

    public static readonly Type6 DestinationReachedLeft = new("DestinationReachedLeft");

    public static readonly Type6 Straight = new("Straight");

    public static readonly Type6 SlightRight = new("SlightRight");

    public static readonly Type6 Right = new("Right");

    public static readonly Type6 SharpRight = new("SharpRight");

    public static readonly Type6 TurnAroundRight = new("TurnAroundRight");

    public static readonly Type6 TurnAroundLeft = new("TurnAroundLeft");

    public static readonly Type6 SharpLeft = new("SharpLeft");

    public static readonly Type6 Left = new("Left");

    public static readonly Type6 SlightLeft = new("SlightLeft");

    public static readonly Type6 ExitRight = new("ExitRight");

    public static readonly Type6 ExitLeft = new("ExitLeft");

    public static readonly Type6 StayRight = new("StayRight");

    public static readonly Type6 StayLeft = new("StayLeft");

    public static readonly Type6 Merge = new("Merge");

    public static readonly Type6 Roundabout = new("Roundabout");

    public static readonly Type6 FerryEnter = new("FerryEnter");

    public static readonly Type6 FerryExit = new("FerryExit");

    public static readonly Type6 Transit = new("Transit");

    public static readonly Type6 TransitTransfer = new("TransitTransfer");

    public static readonly Type6 TransitRemainOn = new("TransitRemainOn");

    public static readonly Type6 TransitConnectionStart = new("TransitConnectionStart");

    public static readonly Type6 TransitConnectionTransfer = new("TransitConnectionTransfer");

    public static readonly Type6 TransitConnectionDestination = new("TransitConnectionDestination");

    public static readonly Type6 PostTransitConnectionDestination = new("PostTransitConnectionDestination");

    public static readonly Type6 MergeRight = new("MergeRight");

    public static readonly Type6 MergeLeft = new("MergeLeft");

    public static Type6 FromValue(string value) => FromValueCore(value);
}
