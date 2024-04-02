using BlazorUI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorUI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<ChatModel> Chats { get; set; }

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
