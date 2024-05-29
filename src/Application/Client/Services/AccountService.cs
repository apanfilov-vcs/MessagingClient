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
            
            if (response is null)
            {
                throw new Exception("Failed to complete endpoint request.");
            }
            else if (response.Success is false || response.Data is null)
            {
                throw new Exception($"Server returned error: {response.Message}");
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

            if (response is null)
            {
                throw new Exception("Failed to complete endpoint request.");
            }
            else if (response.Success is false || response.Data is null)
            {
                throw new Exception($"Server returned error: {response.Message}");
            }
        }
    }
}