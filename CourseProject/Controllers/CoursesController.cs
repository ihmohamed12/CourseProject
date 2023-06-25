using CourseProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace ELearningTask.Controllers
{
    public class CoursesController : Controller
    {
        ApplicationDbContext _db;
        public CoursesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var allCourses = _db.Courses.ToList();
            return View(allCourses);
        }
        public IActionResult Intro()
        {
            return View();
        }
        public IActionResult Path()
        {
            return View();
        }
        public IActionResult Level()
        {
            return View();
        }
    }
}
