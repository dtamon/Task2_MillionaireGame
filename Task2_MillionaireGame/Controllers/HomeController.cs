using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Diagnostics;
using Task2_MillionaireGame.Domain;
using Task2_MillionaireGame.Models;
using Task2_MillionaireGame.Services;
using Task2_MillionaireGame.Services.AnswerService;
using Task2_MillionaireGame.Services.LevelService;
using Task2_MillionaireGame.Services.QuestionService;

namespace Task2_MillionaireGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService service;
        private int levelId = 1;

        public HomeController(ILogger<HomeController> logger, IHomeService service)
        {
            this.service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(service.GetGameViewModel(levelId));
        }

        [HttpPost]
        public IActionResult Index(GameViewModel model, bool answer) 
        {
            if (true)
            {
                levelId++;
            } else
            {
                levelId = 1;
            }
            return View(service.GetGameViewModel(levelId));
        }

        public IActionResult AddQuestion()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}