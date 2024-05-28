namespace Application.Client.Interfaces
{
    public interface ITokenService
    {
        Task<string> GetTokenAsync();
        Task SaveTokenAsync(string token);
        Task RemoveTokenAsync();
    }
}