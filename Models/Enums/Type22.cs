using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// GeoJSON geometry type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type22>))]
public sealed record Type22 : StringEnum<Type22>
{
    private Type22(string value) : base(value)
    {
    }

    public static readonly Type22 MultiLineString = new("MultiLineString");

    public static Type22 FromValue(string value) => FromValueCore(value);
}
