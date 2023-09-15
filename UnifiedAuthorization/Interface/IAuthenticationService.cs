using UnifiedAuthorization.Service;

namespace UnifiedAuthorization.Interface;

public interface IAuthenticationService
{ 
    object authenticationJwtUser(object user);
}