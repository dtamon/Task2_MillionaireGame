using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task2_MillionaireGame.Models;
using Task2_MillionaireGame.Services;

namespace Task2_MillionaireGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _service;
        private int levelsCount;

        public HomeController(ILogger<HomeController> logger, IHomeService service)
        {
            _service = service;
            _logger = logger;
            levelsCount = _service.GetLevelsCount();
        }

        public IActionResult Index()
        {
            return View(_service.GetGameViewModel());
        }

        [HttpPost]
        public IActionResult Index(GameViewModel model, int answerId) 
        {
            if (_service.CheckAnswer(answerId))
            {
                if(model.CurrentLevel == levelsCount)
                {
                    return View("Millionaire");
                }
                else
                {
                    return View(_service.UpdateGameViewModel(model));
                }     
            } 
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public IActionResult Result(GameViewModel model)
        {
            return View(model);
        }

        public IActionResult Millionaire()
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