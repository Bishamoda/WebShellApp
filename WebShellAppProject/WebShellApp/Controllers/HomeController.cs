using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShellApp.BL;
using WebShellApp.Models;
using WebShellApp.ViewModels;

namespace WebShellApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShell _shell;
        private readonly IHistory _history;

        public HomeController(ILogger<HomeController> logger, IShell shell, IHistory history)
        {
            _logger = logger;
            _shell = shell;
            _history = history;
        }

        public IActionResult Index()
        {
            return View(_history.ShowHistory(0));
        }

        [HttpPost]
        public IActionResult Add(string command)
        {
            string output = _shell.Execute(command);

            _history.Add(command, output);

            return Content(output);
        }

        public IActionResult ShowHistory(int page)
        {
            return PartialView(_history.ShowHistory(0));
        }

        public IActionResult Privacy()
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