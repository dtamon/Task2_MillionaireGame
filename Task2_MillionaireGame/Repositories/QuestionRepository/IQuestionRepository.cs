using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;

namespace Task2_MillionaireGame.Services.QuestionService
{
    public interface IQuestionRepository
    {
        public List<Question> GetQuestionsByLevelId(int id);

    }
}
