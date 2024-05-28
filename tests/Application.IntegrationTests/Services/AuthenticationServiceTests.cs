using Application.Interfaces;
using Application.Services;

namespace Application.IntegrationTests.Services
{
    public class AuthenticationServiceTests
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationServiceTests()
        {
            var httpClient = new HttpClient{ BaseAddress = new Uri("http://localhost:5000") };

            _authenticationService = new AuthenticationService(httpClient);
        }

        [Fact]
        public async void ClientSendsRegisterRequest()
        {
            var request = await _authenticationService.Register("Artem", "123");

            Assert.True(request.Message is not null);
        }

        [Fact]
        public async void ClientSendsLoginRequest()
        {
            var request = await _authenticationService.Login("Artem", "123");

            Assert.True(request.Message is not null);
        }
    }
}