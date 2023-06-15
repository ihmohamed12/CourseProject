using CourseProject.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;


namespace CourseProject.Areas.Admin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }



    }
}
