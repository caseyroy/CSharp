using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogReg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "First Name must be entered")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        [Display(Name = "First Name: ")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name must be entered")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters")]
        [Display(Name = "Last Name: ")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email must be entered")]
        [EmailAddress(ErrorMessage = "Invalid email, please re-enter")]
        [Display(Name = "Email: ")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password must be entered")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required(ErrorMessage = "Must confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        [Compare("Password", ErrorMessage = "Passwords must be identical")]
        [NotMapped]

        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}