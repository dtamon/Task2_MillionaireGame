using Microsoft.Identity.Client;
using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;
using Task2_MillionaireGame.Services.AnswerService;
using Task2_MillionaireGame.Services.LevelService;
using Task2_MillionaireGame.Services.QuestionService;

namespace Task2_MillionaireGame.Services
{
    public class HomeService : IHomeService
    {
        private readonly ILevelRepository levelRepository;
        private readonly IQuestionRepository questionRepository;
        private readonly IAnswerRepository answerRepository;
        public GameViewModel model;

        public HomeService(ILevelRepository levelRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            this.levelRepository = levelRepository;
            this.questionRepository = questionRepository;
            this.answerRepository = answerRepository;
        }

        public GameViewModel GetGameViewModel(int levelId)
        {
            IList<Question> questions = questionRepository.GetQuestionsById(levelId);
            var drawnQuestion = RandomElement(questions);
            IList<Answer> answers = answerRepository.GetAnwersById(drawnQuestion.Id);
            var correctAnswer = answers.Where(x => x.IsCorrect == true).FirstOrDefault();
            model = new GameViewModel()
            {
                Level = levelRepository.GetLevelById(levelId),
                Question = drawnQuestion,
                AnswerA = RandomElement(answers),
                AnswerB = RandomElement(answers),
                AnswerC = RandomElement(answers),
                AnswerD = RandomElement(answers),
                CorrectAnswer = correctAnswer
            };

            return model;
        }
        public Level GetAmountWon(int levelId)
        {
            return levelRepository.GetLevelById(levelId);
        }

        public bool CheckAnswer(string answer)
        {
            switch (answer)
            {
                case "A":
                    if (model.AnswerA.IsCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "B":
                    if (model.AnswerB.IsCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "C":
                    if (model.AnswerC.IsCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "D":
                    if (model.AnswerD.IsCorrect)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default: 
                    return false;
            }
        }

        public static T RandomElement<T>(IList<T> list)
        {
            T element = list[new Random().Next(list.Count)];
            list.Remove(element);
            return element;
        }    
    }
}
