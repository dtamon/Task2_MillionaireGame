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

        public GameViewModel GetGameViewModel(int levelId)
        {
            IList<Question> questions = _questionRepository.GetQuestionsById(levelId);
            var drawnQuestion = RandomElement(questions);
            IList<Answer> answers = _answerRepository.GetAnwersById(drawnQuestion.Id);
            var model = new GameViewModel()
            {
                Level = _levelRepository.GetLevelById(levelId),
                CurrentLevel = levelId,
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
            model.CurrentLevel++;
            model.Level = _levelRepository.GetLevelById(model.CurrentLevel);
            IList<Question> questions = _questionRepository.GetQuestionsById(model.CurrentLevel);
            model.Question = RandomElement(questions);
            IList<Answer> answers = _answerRepository.GetAnwersById(model.Question.Id);
            model.AnswerA = RandomElement(answers);
            model.AnswerB = RandomElement(answers);
            model.AnswerC = RandomElement(answers);
            model.AnswerD = RandomElement(answers);
            model.PrizeWon = _levelRepository.GetLevelById(model.CurrentLevel-1).Prize;
            return model;
        }



        public int GetAmountWon(int levelId)
        { 
            if(levelId == 1)
            {
                return 0;
            } else
            {
                levelId--;
                return _levelRepository.GetLevelById(levelId).Prize;
            }
            
        }

        public bool CheckAnswer(int answerId)
        {
            return _answerRepository.GetAnswer(answerId).IsCorrect;
        }
        public int GetLevelsCount()
        {
            return _levelRepository.GetAllLevels().Count();
        }

        public static T RandomElement<T>(IList<T> list)
        {
            T element = list[new Random().Next(list.Count)];
            list.Remove(element);
            return element;
        }

        
    }
}
