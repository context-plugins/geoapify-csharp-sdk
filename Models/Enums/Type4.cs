using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// The type of feature to avoid, such as toll roads, highways, or specific geographic locations.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : StringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Tolls = new("tolls");

    public static readonly Type4 Ferries = new("ferries");

    public static readonly Type4 Highways = new("highways");

    public static readonly Type4 Location = new("location");

    public static Type4 FromValue(string value) => FromValueCore(value);
}
