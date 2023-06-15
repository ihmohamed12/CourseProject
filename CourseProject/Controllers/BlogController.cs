using Microsoft.AspNetCore.Mvc;

namespace ELearningTask.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
