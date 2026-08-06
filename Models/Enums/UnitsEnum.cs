using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Distance units used
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UnitsEnum>))]
public sealed record UnitsEnum : StringEnum<UnitsEnum>
{
    private UnitsEnum(string value) : base(value)
    {
    }

    public static readonly UnitsEnum Metric = new("metric");

    public static readonly UnitsEnum Imperial = new("imperial");

    public static UnitsEnum FromValue(string value) => FromValueCore(value);
}
