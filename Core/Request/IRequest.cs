using System.Net.Http;

namespace Geoapify.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}