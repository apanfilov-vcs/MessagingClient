using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagingClient.DTOs;
using MessagingClient.Models;

namespace MessagingClient.Services
{
    public interface IAPIAuthenticationService
    {
        Task<ServiceResponse<GetUserDto>> Register(string name, string password);
        Task<ServiceResponse<AuthenticationJWT>> RequestAuthenticationToken(string name, string password);
        Task<ServiceResponse<GetUserDto>> Login(string token);
        Task<bool> IsLoggedIn();
        Task Logout();
    }
}