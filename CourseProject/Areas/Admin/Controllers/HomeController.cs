using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Areas.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
  
        public IActionResult Index()
        {
            return View();
        }

    }
}
