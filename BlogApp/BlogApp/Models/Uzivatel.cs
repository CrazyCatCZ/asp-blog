using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Uzivatel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = String.Empty;
        [Required]
        public string Password { get; set; } = String.Empty;
    }
}
