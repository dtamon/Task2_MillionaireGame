using System.ComponentModel.DataAnnotations;

namespace Task2_MillionaireGame.Domain
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
        [Required]
        public Question? Question { get; set; }
    }
}
