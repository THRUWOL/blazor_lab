using BlazorUI.Models;

namespace BlazorUI.Services
{
    public interface IAuthService
    {
        Task<AccountModel> RegisterAsync(string username, string password, string avatarUrl);
        Task<AccountModel> LoginAsync(string username, string password);
    }
}
