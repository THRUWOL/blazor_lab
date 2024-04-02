using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Models
{
    public class AccountModel
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public bool IsOnline { get; set; }
        public string? AvatarUrl { get; set; }

    }
}
