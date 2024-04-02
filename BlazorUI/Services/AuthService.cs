using BlazorUI.Data;
using BlazorUI.Models;

namespace BlazorUI.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _dbContext;
        public AuthService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AccountModel> LoginAsync(string username, string password)
        {
            using var db = _dbContext;
            var account = db.Accounts.FirstOrDefault(u => u.UserName.Equals(username) && u.Password.Equals(password));
            return account;
        }

        public async Task<AccountModel> RegisterAsync(string username, string password, string avatarUrl)
        {
            using var db = _dbContext;
            db.Accounts.Add(new AccountModel { UserName = username, Password = password, AvatarUrl = avatarUrl });
            db.SaveChanges();
            var account = await LoginAsync(username, password);

            return account;

        }
    }
}
