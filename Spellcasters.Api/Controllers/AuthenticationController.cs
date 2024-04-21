using Microsoft.AspNetCore.Mvc;
using Spellcasters.Application.Services.Authentication;
using Spellcasters.Contracts.Authentication.Login;
using Spellcasters.Contracts.Authentication.Register;

namespace Spellcasters.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        RegisterResult registerResult = _authenticationService.Register(
            request.FirstName, 
            request.LastName, 
            request.Email,
            request.Password);

        RegisterResponse registerResponse = new RegisterResponse(
            registerResult.Id, 
            registerResult.FirstName, 
            registerResult.LastName, 
            registerResult.Email,
            registerResult.Token);

        return Ok(registerResponse);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        LoginResult loginResult = _authenticationService.Login(
            request.Email, 
            request.Password);

        LoginResponse loginResponse = new LoginResponse(
            loginResult.Id, 
            loginResult.FirstName, 
            loginResult.LastName, 
            loginResult.Email,
            loginResult.Token);

        return Ok(loginResponse);
    }
}
