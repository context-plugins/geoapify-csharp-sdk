using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Geoapify.Core.Extensions;
using Geoapify.Core.Models;

namespace Geoapify.Models.AnyOf;

[JsonConverter(typeof(GeocodeReverseResponseConverter))]
public record GeocodeReverseResponse
{
    private readonly Optional<ReverseGeocodingJsonResponse> _reverseGeocodingJsonResponseValue;

    private readonly Optional<ReverseGeocodingGeoJsonResponse> _reverseGeocodingGeoJsonResponseValue;

    private GeocodeReverseResponse(Optional<ReverseGeocodingJsonResponse> reverseGeocodingJsonResponseValue,
        Optional<ReverseGeocodingGeoJsonResponse> reverseGeocodingGeoJsonResponseValue)
    {
        _reverseGeocodingJsonResponseValue = reverseGeocodingJsonResponseValue;
        _reverseGeocodingGeoJsonResponseValue = reverseGeocodingGeoJsonResponseValue;
    }

    public static GeocodeReverseResponse ReverseGeocodingJsonResponse(ReverseGeocodingJsonResponse value) =>
        new(Optional<ReverseGeocodingJsonResponse>.Some(value), default);

    public static GeocodeReverseResponse ReverseGeocodingGeoJsonResponse(ReverseGeocodingGeoJsonResponse value) =>
        new(default, Optional<ReverseGeocodingGeoJsonResponse>.Some(value));

    public bool TryGetReverseGeocodingJsonResponse(out ReverseGeocodingJsonResponse value) =>
        _reverseGeocodingJsonResponseValue.TryGetValue(out value);

    public bool TryGetReverseGeocodingGeoJsonResponse(out ReverseGeocodingGeoJsonResponse value) =>
        _reverseGeocodingGeoJsonResponseValue.TryGetValue(out value);

    public static implicit operator GeocodeReverseResponse(ReverseGeocodingJsonResponse value) =>
        ReverseGeocodingJsonResponse(value);

    public static implicit operator GeocodeReverseResponse(ReverseGeocodingGeoJsonResponse value) =>
        ReverseGeocodingGeoJsonResponse(value);
}

file sealed class GeocodeReverseResponseConverter : JsonConverter<GeocodeReverseResponse>
{
    public override GeocodeReverseResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ReverseGeocodingJsonResponse>(root,
            options,
            out var reverseGeocodingJsonResponseValue))
        {
            return GeocodeReverseResponse.ReverseGeocodingJsonResponse(reverseGeocodingJsonResponseValue);
        }
        if (JsonSerializer.TryDeserialize<ReverseGeocodingGeoJsonResponse>(root,
            options,
            out var reverseGeocodingGeoJsonResponseValue))
        {
            return GeocodeReverseResponse.ReverseGeocodingGeoJsonResponse(reverseGeocodingGeoJsonResponseValue);
        }
        throw new JsonException($"JSON does not match ReverseGeocodingJsonResponse or ReverseGeocodingGeoJsonResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, GeocodeReverseResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetReverseGeocodingJsonResponse(out var reverseGeocodingJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, reverseGeocodingJsonResponseValue, options);
        }
        else if (value.TryGetReverseGeocodingGeoJsonResponse(out var reverseGeocodingGeoJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, reverseGeocodingGeoJsonResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(GeocodeReverseResponse)} contains no valid value to serialize.");
        }
    }
}
