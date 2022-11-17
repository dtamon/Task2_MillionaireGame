using System.ComponentModel.DataAnnotations;

namespace Task2_MillionaireGame.Domain
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Level Level { get; set; }
        public ICollection<Answer>? Answers { get; set; }
    }
}
