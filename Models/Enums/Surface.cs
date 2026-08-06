using System.Text.Json.Serialization;
using GeoapifyApi.Core.Enum;

namespace GeoapifyApi.Models.Enums;

/// <summary>
/// Type of surface. Possible values paved_smooth, paved, paved_rough, compacted, dirt, gravel, path, impassable
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Surface>))]
public sealed record Surface : StringEnum<Surface>
{
    private Surface(string value) : base(value)
    {
    }

    public static readonly Surface PavedSmooth = new("paved_smooth");

    public static readonly Surface Paved = new("paved");

    public static readonly Surface PavedRough = new("paved_rough");

    public static readonly Surface Compacted = new("compacted");

    public static readonly Surface Dirt = new("dirt");

    public static readonly Surface Gravel = new("gravel");

    public static readonly Surface Path = new("path");

    public static readonly Surface Impassable = new("impassable");

    public static Surface FromValue(string value) => FromValueCore(value);
}
