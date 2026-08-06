using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// GeoJSON geometry type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type31>))]
public sealed record Type31 : StringEnum<Type31>
{
    private Type31(string value) : base(value)
    {
    }

    public static readonly Type31 Polygon = new("Polygon");

    public static readonly Type31 MultiPolygon = new("MultiPolygon");

    public static Type31 FromValue(string value) => FromValueCore(value);
}
