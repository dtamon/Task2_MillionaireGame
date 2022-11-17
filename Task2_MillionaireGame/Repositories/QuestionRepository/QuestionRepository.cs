using Microsoft.EntityFrameworkCore;
using Task2_MillionaireGame.Context;
using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;
using Task2_MillionaireGame.Services.AnswerService;

namespace Task2_MillionaireGame.Services.QuestionService
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly GameDbContext context;
        public QuestionRepository(GameDbContext context)
        {
            this.context = context;
        }

        public List<Question> GetQuestionsByLevelId(int id)
        {
            return context.Questions.Where(x => x.Level.Id == id).ToList();
        }

    }
}
