using System.Net.Http;

namespace GeoapifyApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}