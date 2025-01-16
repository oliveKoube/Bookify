using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users;

public static class UserErrors
{
    public static readonly Error NotFound = new(
        "User.Found",
        "The user with the specified identifier was not found",
        ErrorType.NotFound);

    public static readonly Error InvalidCredentials = new(
        "User.InvalidCredentials",
        "The provided credentials were invalid",
        ErrorType.Failure);
}
