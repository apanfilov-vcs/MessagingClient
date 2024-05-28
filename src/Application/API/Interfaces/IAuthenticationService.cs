using Application.Responses;
using Application.DTOs;

namespace Application.API.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse<GetAuthenticationTokenDto>> Login(string username, string password);
        Task<ServiceResponse<GetUserDto>> Register(string username, string password);
    }
}