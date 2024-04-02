using BlazorUI.Data;

namespace BlazorUI.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _dbContext;
        public AuthService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task RegisterAsync(string username, string password, string avatarUrl)
        {
            throw new NotImplementedException();
        }
    }
}
