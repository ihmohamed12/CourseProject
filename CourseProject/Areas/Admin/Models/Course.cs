using System.ComponentModel.DataAnnotations;

namespace CourseProject.Areas.Admin.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string title { get; set; }
        public string studentsEnrolled { get; set; }

        public int price { get; set; }


        public string img { get; set; } = "https://d2o9wnd5wywfpj.cloudfront.net/covers/32/s_banner/portfolio-08-large.jpg?1621306513";
    }
}
