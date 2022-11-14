namespace Task2_MillionaireGame.Domain
{
    public class Answer
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public bool IsCorrect { get; set; }
        public Question? Question { get; set; }
    }
}
