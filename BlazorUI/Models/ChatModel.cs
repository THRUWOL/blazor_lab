using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Models
{
    public class ChatModel
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
