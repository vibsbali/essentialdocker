using Microsoft.Extensions.Configuration;
using exampleapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace exampleapp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private string message;

        public HomeController(IRepository repo, IConfiguration config)
        {
            repository = repo;
            //message = config["MESSAGE"] ?? "Essential Docker";
            message = $"Essential Docker ({config["HOSTNAME"]})";
        }
        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(repository.Products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
