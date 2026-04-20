using System.ComponentModel.DataAnnotations;

namespace learnMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }

        // Mối quan hệ: 1 sinh viên có nhiều đăng ký lớp học
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}