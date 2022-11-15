using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;

namespace Task2_MillionaireGame.Services.AnswerService
{
    public interface IAnswerRepository
    {
        public List<Answer> GetAnwersById(int id);
        public Answer GetAnswer(int id);

    }
}
