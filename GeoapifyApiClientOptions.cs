using GeoapifyApi.Core.Configuration;
using GeoapifyApi.Servers;

namespace GeoapifyApi;

public class GeoapifyApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
}
