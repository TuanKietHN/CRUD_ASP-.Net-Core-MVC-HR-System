using System.ComponentModel.DataAnnotations;

namespace Aptech.Models
{
    public class Employee
    {
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Fullname is required")]
        public required string EmpName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public required string EmpAddress { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public required string EmpEmail { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int EmpAge { get; set; }

        public Employee() { }
    }

}
