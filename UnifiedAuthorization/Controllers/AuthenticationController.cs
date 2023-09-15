using System.Security;
using Microsoft.AspNetCore.Mvc;
using UnifiedAuthorization.Interface;

namespace UnifiedAuthorization.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost]
    public object GetAuthentication(object user)
    {
        return _authenticationService.authenticationJwtUser(user);
    }
}