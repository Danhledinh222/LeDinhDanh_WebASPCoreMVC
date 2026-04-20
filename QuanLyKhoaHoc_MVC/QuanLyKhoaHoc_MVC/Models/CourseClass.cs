using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learnMVC.Models
{
    public class CourseClass
    {
        [Key]
        public int Id { get; set; }

        public string Semester { get; set; } 
        public int Year { get; set; } 

        // Khóa ngoại liên kết với Course
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        // Khóa ngoại liên kết với Teacher
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        // Mối quan hệ: 1 lớp học phần có nhiều lượt đăng ký
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}