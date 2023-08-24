using Microsoft.AspNetCore.Identity;

namespace JWTAuthServer.Core.Model
{
    public class AppUser : IdentityUser
    {
        public string City { get; set; }

    }
}
