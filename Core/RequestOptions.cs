using Microsoft.Extensions.Logging;

namespace GeoapifyApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
