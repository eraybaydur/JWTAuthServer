using JWTAuthServer.Core.DTOs;
using JWTAuthServer.Core.Model;
using JWTAuthServer.Core.Services;
using JWTAuthServer.Service.Dtos;
using Microsoft.AspNetCore.Identity;

namespace JWTAuthServer.Service.Services;

public class UserService : IUserService
{
    private readonly UserManager<AppUser> _userManager;

    public UserService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto userDto)
    {
        var user = new AppUser
        {
            Email = userDto.Email,
            UserName = userDto.UserName
        };

        var result = await _userManager.CreateAsync(user, userDto.Password);

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(x => x.Description).ToList();
            return Response<AppUserDto>.Fail(new ErrorDto(errors, true), 400);
        }

        return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user), 200);


    }

    public async Task<Response<AppUserDto>> GetUserByNameAsync(string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        if (user == null) return Response<AppUserDto>.Fail("Username not found", 404, true);

        return Response<AppUserDto>.Success(ObjectMapper.Mapper.Map<AppUserDto>(user),200);
    }
}