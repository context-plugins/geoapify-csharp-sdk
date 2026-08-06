using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using GeoapifyApi.Core.Extensions;
using GeoapifyApi.Core.Models;

namespace GeoapifyApi.Models.AnyOf;

[JsonConverter(typeof(CoordinatesConverter))]
public record Coordinates
{
    private readonly Optional<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>> _listOfListOfListOfDoubleValue;

    private readonly Optional<IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>>> _listOfListOfListOfListOfDoubleValue;

    private Coordinates(Optional<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>> listOfListOfListOfDoubleValue,
        Optional<IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>>> listOfListOfListOfListOfDoubleValue)
    {
        _listOfListOfListOfDoubleValue = listOfListOfListOfDoubleValue;
        _listOfListOfListOfListOfDoubleValue = listOfListOfListOfListOfDoubleValue;
    }

    public static Coordinates ListOfListOfListOfDouble(IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>> value) =>
        new(Optional<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>>.Some(value), default);

    public static Coordinates ListOfListOfListOfListOfDouble(IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>> value) =>
        new(default, Optional<IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>>>.Some(value));

    public bool TryGetListOfListOfListOfDouble(out IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>> value) =>
        _listOfListOfListOfDoubleValue.TryGetValue(out value);

    public bool TryGetListOfListOfListOfListOfDouble(out IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>> value) =>
        _listOfListOfListOfListOfDoubleValue.TryGetValue(out value);
}

file sealed class CoordinatesConverter : JsonConverter<Coordinates>
{
    public override Coordinates Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>>(root,
            options,
            out var listOfListOfListOfDoubleValue))
        {
            return Coordinates.ListOfListOfListOfDouble(listOfListOfListOfDoubleValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>>>(root,
            options,
            out var listOfListOfListOfListOfDoubleValue))
        {
            return Coordinates.ListOfListOfListOfListOfDouble(listOfListOfListOfListOfDoubleValue);
        }
        throw new JsonException($"JSON does not match IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>> or IReadOnlyList<IReadOnlyList<IReadOnlyList<IReadOnlyList<double>>>> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Coordinates value, JsonSerializerOptions options)
    {
        if (value.TryGetListOfListOfListOfDouble(out var listOfListOfListOfDoubleValue))
        {
            JsonSerializer.Serialize(writer, listOfListOfListOfDoubleValue, options);
        }
        else if (value.TryGetListOfListOfListOfListOfDouble(out var listOfListOfListOfListOfDoubleValue))
        {
            JsonSerializer.Serialize(writer, listOfListOfListOfListOfDoubleValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Coordinates)} contains no valid value to serialize.");
        }
    }
}
