using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Web;
using Application.DTOs;
using Application.Interfaces;
using Application.RequestAssistants;
using Application.Responses;

namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;
        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<ServiceResponse<GetAuthenticationTokenDto>> Login(string username, string password)
        {
            var urlWithParameters = QueryUtility.Authentication.CreateAuthenticationQuery("/api/Authentication/Login?", username, password);

            var response = await _httpClient.PostAsync(urlWithParameters, null);

            var content = await response.Content.ReadFromJsonAsync<ServiceResponse<GetAuthenticationTokenDto>>();

            if (content is null)
            {
                throw new NullReferenceException("Unable to load/fetch content.");
            }

            return content;
        }

        public async Task<ServiceResponse<GetUserDto>> Register(string username, string password)
        {
            var urlWithParameters = QueryUtility.Authentication.CreateAuthenticationQuery("/api/Authentication/Register?", username, password);

            var response = await _httpClient.PostAsync(urlWithParameters, null);

            var content = await response.Content.ReadFromJsonAsync<ServiceResponse<GetUserDto>>();

            if (content is null)
            {
                throw new NullReferenceException("Unable to load/fetch content");
            }

            return content;
        }
    }
}