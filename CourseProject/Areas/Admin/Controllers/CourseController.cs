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
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        public IActionResult Test()
        {

            return View();

        }
        [HttpGet]
        public IActionResult Edit( int id)
        {

            var course = _db.Courses.Where(e => e.Id==id).FirstOrDefault();
            if(course==null)
            {
                return NotFound();
            }
            return View(course);

        }

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            if (ModelState.IsValid)
            {
                _db.Update(model);
                _db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));

        }


    }
}

