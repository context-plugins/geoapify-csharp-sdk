using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using GeoapifyApi.Core.Extensions;
using GeoapifyApi.Core.Models;

namespace GeoapifyApi.Models.AnyOf;

[JsonConverter(typeof(GeocodeAutocompleteResponseConverter))]
public record GeocodeAutocompleteResponse
{
    private readonly Optional<AutocompleteJsonResponse> _autocompleteJsonResponseValue;

    private readonly Optional<AutocompleteGeoJsonResponse> _autocompleteGeoJsonResponseValue;

    private GeocodeAutocompleteResponse(Optional<AutocompleteJsonResponse> autocompleteJsonResponseValue,
        Optional<AutocompleteGeoJsonResponse> autocompleteGeoJsonResponseValue)
    {
        _autocompleteJsonResponseValue = autocompleteJsonResponseValue;
        _autocompleteGeoJsonResponseValue = autocompleteGeoJsonResponseValue;
    }

    public static GeocodeAutocompleteResponse AutocompleteJsonResponse(AutocompleteJsonResponse value) =>
        new(Optional<AutocompleteJsonResponse>.Some(value), default);

    public static GeocodeAutocompleteResponse AutocompleteGeoJsonResponse(AutocompleteGeoJsonResponse value) =>
        new(default, Optional<AutocompleteGeoJsonResponse>.Some(value));

    public bool TryGetAutocompleteJsonResponse(out AutocompleteJsonResponse value) =>
        _autocompleteJsonResponseValue.TryGetValue(out value);

    public bool TryGetAutocompleteGeoJsonResponse(out AutocompleteGeoJsonResponse value) =>
        _autocompleteGeoJsonResponseValue.TryGetValue(out value);

    public static implicit operator GeocodeAutocompleteResponse(AutocompleteJsonResponse value) =>
        AutocompleteJsonResponse(value);

    public static implicit operator GeocodeAutocompleteResponse(AutocompleteGeoJsonResponse value) =>
        AutocompleteGeoJsonResponse(value);
}

file sealed class GeocodeAutocompleteResponseConverter : JsonConverter<GeocodeAutocompleteResponse>
{
    public override GeocodeAutocompleteResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AutocompleteJsonResponse>(root,
            options,
            out var autocompleteJsonResponseValue))
        {
            return GeocodeAutocompleteResponse.AutocompleteJsonResponse(autocompleteJsonResponseValue);
        }
        if (JsonSerializer.TryDeserialize<AutocompleteGeoJsonResponse>(root,
            options,
            out var autocompleteGeoJsonResponseValue))
        {
            return GeocodeAutocompleteResponse.AutocompleteGeoJsonResponse(autocompleteGeoJsonResponseValue);
        }
        throw new JsonException($"JSON does not match AutocompleteJsonResponse or AutocompleteGeoJsonResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        GeocodeAutocompleteResponse value,
        JsonSerializerOptions options)
    {
        if (value.TryGetAutocompleteJsonResponse(out var autocompleteJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, autocompleteJsonResponseValue, options);
        }
        else if (value.TryGetAutocompleteGeoJsonResponse(out var autocompleteGeoJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, autocompleteGeoJsonResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(GeocodeAutocompleteResponse)} contains no valid value to serialize.");
        }
    }
}
