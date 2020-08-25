using System;
using System.ComponentModel.DataAnnotations;

namespace LogReg.Models
{
    public class LoggedUser
    {
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email: ")]

        public string LoggedEmail { get; set; }

        [Required(ErrorMessage = "Password must be entered")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]

        public string LoggedPass { get; set; }
    }
}