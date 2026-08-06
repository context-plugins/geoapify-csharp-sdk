using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Isoline type (isochrone or isodistance)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type21>))]
public sealed record Type21 : StringEnum<Type21>
{
    private Type21(string value) : base(value)
    {
    }

    public static readonly Type21 Time = new("time");

    public static readonly Type21 Distance = new("distance");

    public static Type21 FromValue(string value) => FromValueCore(value);
}
