using Spellcasters.Application.Common.Interfaces.Authentication;

namespace Spellcasters.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    { 
        _jwtTokenGenerator = jwtTokenGenerator; 
    }

    public RegisterResult Register(string firstName, string lastName, string email, string password)
    {
        //Check if user already exists

        //Create user - generate id

        //Create token
        Guid userId = Guid.NewGuid();
        string token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new RegisterResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            token);
    }

    public LoginResult Login(string email, string password)
    {
        //var token = _jwtTokenGenerator.GenerateToken(username);
        return new LoginResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token");
    }
}
