using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 Country = new("country");

    public static readonly Type3 State = new("state");

    public static readonly Type3 City = new("city");

    public static readonly Type3 Postcode = new("postcode");

    public static readonly Type3 Street = new("street");

    public static readonly Type3 Amenity = new("amenity");

    public static Type3 FromValue(string value) => FromValueCore(value);
}
