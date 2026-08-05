using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

/// <summary>
/// Distance units used, Specifies the unit system to use for measuring distances in the response.
///   - <c>metric</c>: Uses kilometers and meters.
///   - <c>imperial</c>: Uses miles and feet., Distance units used
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
