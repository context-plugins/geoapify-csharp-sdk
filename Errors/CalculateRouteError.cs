using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core.ErrorResponse;
using Geoapify.Core.Models;

namespace Geoapify.Errors;

public sealed class CalculateRouteError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private CalculateRouteError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static CalculateRouteError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static CalculateRouteError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<CalculateRouteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 429 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CalculateRouteErrorResponse : IErrorResponse<CalculateRouteError>
{
    public static CalculateRouteErrorResponse Instance { get; } = new();

    private CalculateRouteErrorResponse()
    {
    }

    public Task<CalculateRouteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CalculateRouteError.Create(response, ct);
}
