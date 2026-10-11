using Microsoft.AspNetCore.Mvc;
using Sean.Models;
using System.Diagnostics;

namespace Sean.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sean()
        {

            StudentModel student = new StudentModel();
            student.ID = 3;
            student.FirstName = "Sean John";
            student.MiddleName = "Santos";
            student.LastName = "Pabadora";
            student.Address = "Tabi tabi";

            ViewBag.WelcomeMessage = "MEMBER 3";
            ViewData["Quote"] = "Sleep Schedule has been shuffled";

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
