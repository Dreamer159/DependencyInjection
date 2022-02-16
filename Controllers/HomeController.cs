using DependencyInjectionExercise.Models;
using DependencyInjectionExercise.Models.Classes;
using DependencyInjectionExercise.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjectionExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private InterfaceA _interfaceA;
        private ClassB _classB;

        public HomeController(ILogger<HomeController> logger,
                               InterfaceA interfaceA,
                               ClassB classB)
        {
            _logger = logger;
            _interfaceA = interfaceA;
            _classB = classB;
        }

        public IActionResult Index()
        {
            ViewData["InstanceA"] = _interfaceA.SomeMethod();
            ViewData["InstanceB"] = _classB.SomeOtherMethod();

            return View();
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