using Application.DTOs;
using Application.Responses;

namespace Application.API.Interfaces
{
    public interface IUserService
    {
        Task<ServiceResponse<List<GetUserDto>>> GetUsers();
        Task<ServiceResponse<GetUserDto>> GetUserById(string id);
        Task<ServiceResponse<GetUserDto>> GetCurrentUser();
        Task<ServiceResponse<GetUserDto>> UpdateCurrentUserName(string name);
        Task<ServiceResponse<GetUserDto>> DeleteCurrentUser();
    }
}