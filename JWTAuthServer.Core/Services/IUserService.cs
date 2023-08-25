using JWTAuthServer.Core.DTOs;
using JWTAuthServer.Service.Dtos;

namespace JWTAuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto userDto);
        Task<Response<AppUserDto>> GetUserByNameAsync(string userName);


    }
}
