using Microsoft.Extensions.Logging;

namespace Geoapify.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
