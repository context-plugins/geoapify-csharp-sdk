using Geoapify.Core.Models;
using Geoapify.Servers;

namespace Geoapify;

public class Server
{
    private readonly ServerEnvironment _environment;
    private readonly ServerOptions _options;

    internal Server(ServerEnvironment environment, ServerOptions options)
    {
        _environment = environment;
        _options = options;
    }

    internal UrlTemplate Default(string path) => _options.Default.Resolve(_environment, path);
    internal UrlTemplate Default1(string path) => _options.Default1.Resolve(_environment, path);
}
