using Task2_MillionaireGame.Domain;

namespace Task2_MillionaireGame.Models
{
    public class QuestionViewModel
    {
        public ICollection<Level> Levels { get; set; }
        public Level? Level { get; set; }
        public string? Question { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Answer1 { get; set; }
        public string? Answer2 { get; set; }
        public string? Answer3 { get; set; }
    }
}
