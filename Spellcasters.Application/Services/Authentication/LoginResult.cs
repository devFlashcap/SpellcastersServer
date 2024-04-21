namespace Spellcasters.Application.Services.Authentication;

public record LoginResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);
