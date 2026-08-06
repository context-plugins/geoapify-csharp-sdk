using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// GeoJSON object type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum FeatureCollection = new("FeatureCollection");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
