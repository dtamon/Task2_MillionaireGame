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
        private readonly ILevelRepository _levelRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public HomeService(ILevelRepository levelRepository, IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            _levelRepository = levelRepository;
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

        public GameViewModel GetGameViewModel()
        {
            var level = _levelRepository.GetLevelById(1);
            IList<Question> questions = _questionRepository.GetQuestionsByLevelId(level.Id);
            var drawnQuestion = RandomElement(questions);
            IList<Answer> answers = _answerRepository.GetAnwersByQuestionId(drawnQuestion.Id);
            var model = new GameViewModel()
            {
                Level = level,
                CurrentLevel = level.Id,
                Question = drawnQuestion,
                AnswerA = RandomElement(answers),
                AnswerB = RandomElement(answers),
                AnswerC = RandomElement(answers),
                AnswerD = RandomElement(answers)
            };

            return model;
        }
        public GameViewModel UpdateGameViewModel(GameViewModel model)
        {
            model.PrizeWon = _levelRepository.GetLevelById(model.CurrentLevel).Prize;
            model.CurrentLevel++;
            model.Level = _levelRepository.GetLevelById(model.CurrentLevel);
            IList<Question> questions = _questionRepository.GetQuestionsByLevelId(model.CurrentLevel);
            model.Question = RandomElement(questions);
            IList<Answer> answers = _answerRepository.GetAnwersByQuestionId(model.Question.Id);
            model.AnswerA = RandomElement(answers);
            model.AnswerB = RandomElement(answers);
            model.AnswerC = RandomElement(answers);
            model.AnswerD = RandomElement(answers);
            
            return model;
        }

        public bool CheckAnswer(int answerId)
        {
            return _answerRepository.GetAnswer(answerId).IsCorrect;
        }
        public int GetLevelsCount()
        {
            return _levelRepository.GetLevels().Count();
        }

        public static T RandomElement<T>(IList<T> list)
        {
            T element = list[new Random().Next(list.Count)];
            list.Remove(element);
            return element;
        }

        
    }
}
