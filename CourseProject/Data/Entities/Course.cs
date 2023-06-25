using System.ComponentModel.DataAnnotations;

namespace CourseProject.Data.Entities
{
    public class Course : BaseEntity
    {

        [Required]
        public string title { get; set; }

        [Required]
        public string
            studentsEnrolled
        { get; set; }
        [Required]
        public int price { get; set; }

        //[NotMapped]
        [Required]
        public string img { get; set; } = "https://d2o9wnd5wywfpj.cloudfront.net/covers/32/s_banner/portfolio-08-large.jpg?1621306513";


        public virtual ICollection<Lesson> lessons { get; set; } = new List<Lesson>();



    }
}
