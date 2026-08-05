using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core.ErrorResponse;
using Geoapify.Core.Models;

namespace Geoapify.Errors;

public sealed class MapMatchingError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private MapMatchingError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static MapMatchingError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static MapMatchingError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<MapMatchingError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 429 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MapMatchingErrorResponse : IErrorResponse<MapMatchingError>
{
    public static MapMatchingErrorResponse Instance { get; } = new();

    private MapMatchingErrorResponse()
    {
    }

    public Task<MapMatchingError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MapMatchingError.Create(response, ct);
}
