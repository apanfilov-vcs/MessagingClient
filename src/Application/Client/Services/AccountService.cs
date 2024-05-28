using Application.API.Interfaces;
using Application.Client.Interfaces;
using Application.DataProcessing;

namespace Application.Client.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ITokenService _tokenService;
        public AccountService(IAuthenticationService authenticationService, ITokenService tokenService)
        {
            _authenticationService = authenticationService;
            _tokenService = tokenService;
        }

        public async Task LoginAsync(string username, string password)
        {
            var response = await _authenticationService.Login(username, password);
            
            if (response.Success is false || response.Data is null)
            {
                if (response.Message is not null)
                {
                    throw new Exception(response.Message);
                }

                throw new Exception("Failed to login.");
            }

            await _tokenService.SaveTokenAsync(response.Data.Value);
        }

        public async Task LogoutAsync()
        {
            await _tokenService.RemoveTokenAsync();
        }

        public async Task RegisterAsync(string username, string password)
        {
            var response = await _authenticationService.Register(username, password);

            if (response.Success is false || response.Data is null)
            {
                if (response.Message is not null)
                {
                    throw new Exception(response.Message);
                }
                
                throw new Exception("Failed to register.");
            }
        }

        public async Task<bool> IsSessionValidAsync()
        {
            var token = await _tokenService.GetTokenAsync();
            var isTokenExpired = TokenHelper.IsTokenExpired(token);

            return isTokenExpired;
        }

        public async Task<string> GetSessionTokenAsync()
        {
            var token = await _tokenService.GetTokenAsync();

            return token;
        }
    }
}