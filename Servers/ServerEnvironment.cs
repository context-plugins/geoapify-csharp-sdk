using System;
using System.Text.Json.Serialization;
using Geoapify.Core.Enum;

namespace Geoapify.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    /// <summary>
    /// Primary Geoapify API endpoint, Main Geoapify API server, Primary Geoapify API endpoint, Primary Geoapify API endpoint, Primary Geoapify API endpoint
    /// </summary>
    public static readonly ServerEnvironment Production = new("production");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onProduction) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Production;
}
