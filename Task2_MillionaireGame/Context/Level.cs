namespace Task2_MillionaireGame.Domain
{
    public class Level
    {
        public int Id { get; set; }
        public int CurrentLevel { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }
}
