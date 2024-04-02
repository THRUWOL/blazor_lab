namespace BlazorUI.Services
{
    public interface IAuthService
    {
        Task RegisterAsync(string username, string password, string avatarUrl);
        Task LoginAsync(string username, string password);
    }
}
