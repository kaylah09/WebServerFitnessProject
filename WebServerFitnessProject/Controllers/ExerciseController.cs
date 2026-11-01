
using Microsoft.AspNetCore.Mvc;

namespace WebServerFitnessProject.Controllers
{
    public class ExerciseController : Controller
    {
        public IActionResult Index()
        {
            return Content("Exercise page coming soon!");
        }
    }
}