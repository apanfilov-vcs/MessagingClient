using System.Net.Http.Json;
using Application.API.Interfaces;
using Application.Client.Interfaces;
using Application.DTOs;
using Application.Responses;

namespace Application.API.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;
        public UserService(HttpClient httpClient, IAccountService accountService, ITokenService tokenService)
        {
            _httpClient = httpClient;
            _accountService = accountService;
            _tokenService = tokenService;

            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public Task<ServiceResponse<GetUserDto>> DeleteCurrentUser()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetUserDto>> GetCurrentUser()
        {
            var token = await _tokenService.GetTokenAsync();

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer {token}");

            var response = await _httpClient.GetAsync("/api/User/GetCurrentUser");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Endpoint request failed.");
            }

            var content = await response.Content.ReadFromJsonAsync<ServiceResponse<GetUserDto>>();

            if (content is null)
            {
                throw new NullReferenceException("Unable to load/fetch content.");
            }

            return content;
        }

        public Task<ServiceResponse<GetUserDto>> GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetUserDto>>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetUserDto>> UpdateCurrentUserName(string name)
        {
            throw new NotImplementedException();
        }
    }
}