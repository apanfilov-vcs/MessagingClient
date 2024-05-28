namespace Application.Client.Interfaces
{
    public interface IAccountService
    {
        Task LoginAsync(string username, string password);
        Task LogoutAsync();
        Task RegisterAsync(string username, string password);
        Task<bool> IsSessionValidAsync();
        Task<string> GetSessionTokenAsync();
    }
}