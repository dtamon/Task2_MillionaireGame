using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2_MillionaireGame.Models;
using Task2_MillionaireGame.Services;

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
        public IActionResult Index(GameViewModel model, int answerId) 
        {
            if (service.CheckAnswer(answerId))
            {
                levelId++;
            } else
            {
                levelId = 1;
            }
            return View(service.GetGameViewModel(levelId));
        }

        public IActionResult Result(int amountWon)
        {
            ViewBag.param = amountWon;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}