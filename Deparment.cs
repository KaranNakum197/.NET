using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Student> Students { get; set; }
    }
}
