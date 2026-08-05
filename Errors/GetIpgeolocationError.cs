using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core.ErrorResponse;
using Geoapify.Core.Models;

namespace Geoapify.Errors;

public sealed class GetIpgeolocationError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetIpgeolocationError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetIpgeolocationError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetIpgeolocationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetIpgeolocationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 429 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetIpgeolocationErrorResponse : IErrorResponse<GetIpgeolocationError>
{
    public static GetIpgeolocationErrorResponse Instance { get; } = new();

    private GetIpgeolocationErrorResponse()
    {
    }

    public Task<GetIpgeolocationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetIpgeolocationError.Create(response, ct);
}
