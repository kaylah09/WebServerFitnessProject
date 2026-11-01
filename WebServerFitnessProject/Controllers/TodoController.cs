using Microsoft.AspNetCore.Mvc;

namespace WebServerFitnessProject.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
