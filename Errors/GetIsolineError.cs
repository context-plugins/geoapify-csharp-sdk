using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core.ErrorResponse;
using Geoapify.Core.Models;

namespace Geoapify.Errors;

public sealed class GetIsolineError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetIsolineError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetIsolineError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetIsolineError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetIsolineError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 429 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetIsolineErrorResponse : IErrorResponse<GetIsolineError>
{
    public static GetIsolineErrorResponse Instance { get; } = new();

    private GetIsolineErrorResponse()
    {
    }

    public Task<GetIsolineError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetIsolineError.Create(response, ct);
}
