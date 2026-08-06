using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using GeoapifyApi.Core.Extensions;
using GeoapifyApi.Core.Models;

namespace GeoapifyApi.Models.AnyOf;

[JsonConverter(typeof(RoutingResponseConverter))]
public record RoutingResponse
{
    private readonly Optional<RoutingJsonResponse> _routingJsonResponseValue;

    private readonly Optional<RoutingGeoJsonResponse> _routingGeoJsonResponseValue;

    private RoutingResponse(Optional<RoutingJsonResponse> routingJsonResponseValue,
        Optional<RoutingGeoJsonResponse> routingGeoJsonResponseValue)
    {
        _routingJsonResponseValue = routingJsonResponseValue;
        _routingGeoJsonResponseValue = routingGeoJsonResponseValue;
    }

    public static RoutingResponse RoutingJsonResponse(RoutingJsonResponse value) =>
        new(Optional<RoutingJsonResponse>.Some(value), default);

    public static RoutingResponse RoutingGeoJsonResponse(RoutingGeoJsonResponse value) =>
        new(default, Optional<RoutingGeoJsonResponse>.Some(value));

    public bool TryGetRoutingJsonResponse(out RoutingJsonResponse value) =>
        _routingJsonResponseValue.TryGetValue(out value);

    public bool TryGetRoutingGeoJsonResponse(out RoutingGeoJsonResponse value) =>
        _routingGeoJsonResponseValue.TryGetValue(out value);

    public static implicit operator RoutingResponse(RoutingJsonResponse value) => RoutingJsonResponse(value);

    public static implicit operator RoutingResponse(RoutingGeoJsonResponse value) =>
        RoutingGeoJsonResponse(value);
}

file sealed class RoutingResponseConverter : JsonConverter<RoutingResponse>
{
    public override RoutingResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<RoutingJsonResponse>(root, options, out var routingJsonResponseValue))
        {
            return RoutingResponse.RoutingJsonResponse(routingJsonResponseValue);
        }
        if (JsonSerializer.TryDeserialize<RoutingGeoJsonResponse>(root,
            options,
            out var routingGeoJsonResponseValue))
        {
            return RoutingResponse.RoutingGeoJsonResponse(routingGeoJsonResponseValue);
        }
        throw new JsonException($"JSON does not match RoutingJsonResponse or RoutingGeoJsonResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, RoutingResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetRoutingJsonResponse(out var routingJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, routingJsonResponseValue, options);
        }
        else if (value.TryGetRoutingGeoJsonResponse(out var routingGeoJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, routingGeoJsonResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(RoutingResponse)} contains no valid value to serialize.");
        }
    }
}
