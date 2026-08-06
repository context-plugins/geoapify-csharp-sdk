using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GeoapifyApi.Core.ErrorResponse;
using GeoapifyApi.Core.Models;

namespace GeoapifyApi.Errors;

public sealed class GenerateRouteMatrixError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GenerateRouteMatrixError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GenerateRouteMatrixError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GenerateRouteMatrixError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GenerateRouteMatrixError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 429 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GenerateRouteMatrixErrorResponse : IErrorResponse<GenerateRouteMatrixError>
{
    public static GenerateRouteMatrixErrorResponse Instance { get; } = new();

    private GenerateRouteMatrixErrorResponse()
    {
    }

    public Task<GenerateRouteMatrixError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GenerateRouteMatrixError.Create(response, ct);
}
