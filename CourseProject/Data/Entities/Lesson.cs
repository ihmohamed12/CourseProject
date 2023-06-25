using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Data.Entities
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }

        public string title { get; set; }
        public string description { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public Lesson(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
