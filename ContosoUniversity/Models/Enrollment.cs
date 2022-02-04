#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int ID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // Enrollment initiator
        public Student Student { get; set; }

        // The course which the enrollment is made to
        public Course Course { get; set; }

    }
}
