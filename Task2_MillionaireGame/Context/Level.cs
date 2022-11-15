using System.ComponentModel.DataAnnotations;

namespace Task2_MillionaireGame.Domain
{
    public class Level
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Prize { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }
}
