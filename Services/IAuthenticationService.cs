using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingClient.Services
{
    public interface IAuthenticationService
    {
        Task<bool> LoginAsync(string username, string password);
        Task LogoutAsync();
        Task<bool> IsAuthenticatedAsync();
        Task<bool> GetAccessTokenAsync();
        Task<bool> RegisterAsync(string username, string password);
    }
}