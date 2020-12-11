using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("process")]

        public IActionResult Process(string Name, string Location, string Language)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            return View("results");
        }

    }
}