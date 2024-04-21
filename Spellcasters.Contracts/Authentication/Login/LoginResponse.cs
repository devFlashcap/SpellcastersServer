namespace Spellcasters.Contracts.Authentication.Login;

public record LoginResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);