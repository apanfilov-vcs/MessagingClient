using Application.Common;
using Application.DTOs;

namespace Application
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse<GetAuthenticationTokenDto>> Login(string username, string password);
        Task<ServiceResponse<GetUserDto>> Register(string username, string password);
    }
}