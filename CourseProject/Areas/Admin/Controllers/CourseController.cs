using CourseProject.Areas.Admin.Data;
using CourseProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        ApplicationDbContext _db;

        public CourseController(ApplicationDbContext db) { 
        
        _db=db;
        }

        public IActionResult Index()
        {
            var courseList = _db.Courses.ToList(); //new List<Course>();

            return View(courseList);
        }
        [HttpGet]
        public IActionResult SaveNew()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveNew(Course newCourseData)
        {
            // Sava data to db
            _db.Courses.Add(newCourseData);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Test()
        {

            return View();

        }

    }
}

