using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Geoapify.Core.ErrorResponse;
using Geoapify.Core.Models;

namespace Geoapify.Errors;

public sealed class GetPlacesError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetPlacesError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetPlacesError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetPlacesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetPlacesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPlacesErrorResponse : IErrorResponse<GetPlacesError>
{
    public static GetPlacesErrorResponse Instance { get; } = new();

    private GetPlacesErrorResponse()
    {
    }

    public Task<GetPlacesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPlacesError.Create(response, ct);
}
