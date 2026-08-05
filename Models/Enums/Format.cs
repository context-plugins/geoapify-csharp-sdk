using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Format>))]
public sealed record Format : StringEnum<Format>
{
    private Format(string value) : base(value)
    {
    }

    public static readonly Format Json = new("json");

    public static readonly Format Xml = new("xml");

    public static readonly Format Geojson = new("geojson");

    public static Format FromValue(string value) => FromValueCore(value);
}
