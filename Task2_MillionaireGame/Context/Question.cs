namespace Task2_MillionaireGame.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public Level? Level { get; set; }
        public ICollection<Answer>? Answers { get; set; }
    }
}
