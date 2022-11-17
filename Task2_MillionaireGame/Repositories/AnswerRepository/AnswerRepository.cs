using Microsoft.EntityFrameworkCore;
using Task2_MillionaireGame.Context;
using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;

namespace Task2_MillionaireGame.Services.AnswerService
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly GameDbContext context;
        public AnswerRepository(GameDbContext context)
        {
            this.context = context;
        }

        public Answer GetAnswer(int id)
        {
            return context.Answers.FirstOrDefault(x => x.Id == id);
        }

        public List<Answer> GetAnwersByQuestionId(int id)
        {
            return context.Answers.Where(x => x.Question.Id == id).ToList();
        }
    }
}
