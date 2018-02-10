using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
         public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/

        public IActionResult Welcome(string Name, int NumTimes = 1)
        {
            ViewData["Message"] = "Hello " + Name;
            ViewData["NumTimes"] = NumTimes;

            return View();
        }
    }
}