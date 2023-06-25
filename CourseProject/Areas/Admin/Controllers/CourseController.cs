using CourseProject.Data.Entities;
using CourseProject.Data;
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
            if (ModelState.IsValid)
            {
                _db.Courses.Add(newCourseData);
                newCourseData.lessons.Add(new Lesson("Test", "Test"));
                newCourseData.lessons.Add(new Lesson("Test2", "Test"));
                newCourseData.lessons.Add(new Lesson("Test3", "Test"));


                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        public IActionResult Test()
        {

            return View();

        }

    }
}

