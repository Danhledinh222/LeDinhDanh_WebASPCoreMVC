using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learnMVC.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        // Khóa ngoại liên kết với Student
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        // Khóa ngoại liên kết với CourseClass
        public int CourseClassId { get; set; }
        [ForeignKey("CourseClassId")]
        public CourseClass CourseClass { get; set; }

        public float? Grade { get; set; }
    }
}