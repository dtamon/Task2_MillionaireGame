using Task2_MillionaireGame.Domain;

namespace Task2_MillionaireGame.Models
{
    public class GameViewModel
    {
        public Level? Level { get; set; }
        public int CurrentLevel { get; set; }  
        public int PrizeWon { get; set; }
        public Question? Question { get; set; }
        public Answer? AnswerA { get; set; }
        public Answer? AnswerB { get; set; }
        public Answer? AnswerC { get; set; }
        public Answer? AnswerD { get; set; }
    }
}
