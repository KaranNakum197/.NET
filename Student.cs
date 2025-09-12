using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(18, 60)]
        public int Age { get; set; }

        // Foreign key
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        // Navigation property
        public Department Department { get; set; }
    }
}
