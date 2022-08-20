using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Assignment2.Model
{
    public class Staff // Staff class
    {
        [Required]  
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 20, ErrorMessage = "Name cannot be longer than 120 characters and less than 20 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 20, ErrorMessage = "Surname cannot be longer than 120 characters and less than 20 characters")]
        public string LastName { get; set; }

        [Required]
        [Range(typeof(DateTime), "11/11/1945","10/10/2002",  ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; }
        [Required]
        [Range(typeof(double), "2000", "9000")]
        public double Salary { get; set; }
    }

  
}
