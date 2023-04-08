
namespace BuberDinner.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string Password,
    string Email,
    string Token
);