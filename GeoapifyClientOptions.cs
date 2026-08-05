using Geoapify.Core.Configuration;
using Geoapify.Servers;

namespace Geoapify;

public class GeoapifyClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
}
