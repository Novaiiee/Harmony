using Microsoft.AspNetCore.Identity;

namespace Panthera.Application.Contracts;

public class Response<T>
{
    public T? Data { get; set; }
    public string Message { get; set; } = null!;
    public int StatusCode { get; set; } = 200;
}

public class IdentityResponse<T> : Response<T>
{
    public IEnumerable<IdentityError> Errors { get; set; } = null!;
}