using Harmony.Application.Contracts;

namespace Harmony.Api.Helpers;

public class UserNotFoundResponse : Response<string>
{
    public UserNotFoundResponse()
    {
        Data = null;
        Message = "User does not exist";
        StatusCode = 400;
    }
}