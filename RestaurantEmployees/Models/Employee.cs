using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantEmployees.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter the employee's name!"), MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "Please enter the employee's role!"), MaxLength(20)]
        public string Role { get; set; }

        [Display(Name = "Date of birth")]
        [Required(ErrorMessage = "Please enter the employee's date of birth!")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}