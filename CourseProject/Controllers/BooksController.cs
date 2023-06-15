using Microsoft.AspNetCore.Mvc;

namespace ELearningTask.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
