using JWTAuthServer.Core.DTOs;
using JWTAuthServer.Core.Model;

namespace JWTAuthServer.Core.Services
{
    public interface ITokenService
    {

        TokenDto CreateToken(AppUser appUser);
        ClientTokenDto CreateTokenByClient(Client client);

    }
}
