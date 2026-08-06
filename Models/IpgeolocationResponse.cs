using System.Collections.Generic;
using System.Text.Json.Serialization;
using GeoapifyApi.Core.Validation;
using GeoapifyApi.Core.Validation.Attributes;

namespace GeoapifyApi.Models;

public record IpgeolocationResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("city")]
    public Ipcity? City { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("continent")]
    public Ipcontinent? Continent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public Ipcountry? Country { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Iplocation? Location { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subdivisions")]
    public IReadOnlyList<Ipsubdivision>? Subdivisions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public Ipstate? State { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("datasource")]
    public IReadOnlyList<Ipdatasource>? Datasource { get; init; }

    /// <summary>
    /// The IP address that was looked up
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ip")]
    [Format(FormatKind.Ipv4)]
    public string? Ip { get; init; }
}
