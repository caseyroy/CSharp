using System;
using System.ComponentModel.DataAnnotations;

namespace FormSub.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name must be entered")]
        [MinLength(2, ErrorMessage = "Name must be at least two characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Dojo must be selected")]
        public string Dojo { get; set; }

        [Required(ErrorMessage = "Language must be selected")]
        public string Language { get; set; }

        [MaxLength(20, ErrorMessage = "Comments must be no more than 20 characters")]

        public string Comment { get; set; }
    }
}