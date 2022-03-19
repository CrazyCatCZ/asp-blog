using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Clanek
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = String.Empty;
        [Required]
        public string Content { get; set; } = String.Empty;
        [Required]
        public DateTime? Termin { get; set; }
    }
}
