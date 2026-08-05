using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : StringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 Time = new("time");

    public static readonly Type5 Distance = new("distance");

    public static Type5 FromValue(string value) => FromValueCore(value);
}
