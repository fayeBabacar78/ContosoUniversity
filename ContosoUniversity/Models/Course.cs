#nullable disable
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        // Enrollments made to this course
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}