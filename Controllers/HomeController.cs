using DependencyInjectionExercise.Models;
using DependencyInjectionExercise.Models.Classes;
using DependencyInjectionExercise.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unity;
using Unity.Lifetime;

namespace DependencyInjectionExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var instanceA = (InterfaceA)ContainerProvider.Container.Services.GetService(typeof(InterfaceA));
            var instanceB = (ClassB)ContainerProvider.Container.Services.GetService(typeof(ClassB));

            ViewData["InstanceA"] = instanceA.SomeMethod();
            ViewData["InstanceB"] = instanceB.SomeOtherMethod();

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