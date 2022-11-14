﻿using Microsoft.Identity.Client;
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
            var model = new GameViewModel()
            {
                Level = levelRepository.GetLevelById(levelId),
                Question = drawnQuestion,
                AnswerA = RandomElement(answers),
                AnswerB = RandomElement(answers),
                AnswerC = RandomElement(answers),
                AnswerD = RandomElement(answers)
            };

            return model;
        }
        public Level GetAmountWon(int levelId)
        {
            return levelRepository.GetLevelById(levelId);
        }

        public static T RandomElement<T>(IList<T> list)
        {
            T element = list[new Random().Next(list.Count)];
            list.Remove(element);
            return element;
        }

        
    }
}