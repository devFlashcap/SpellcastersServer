namespace Spellcasters.Contracts.Authentication.Register;

public record RegisterResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);