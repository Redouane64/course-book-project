using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CourseBook.WebApi.Models
{
    public class RegisterationForm
    {
        [Required]
        [PersonalData]
        public string Name { get; set; }

        [Required]
        [PersonalData]
        public string Phone{ get; set; }

        [Required]
        [PersonalData]
        public DateTime Birthday { get; set; }

        [Required]
        public string Faculty { get; set; }

        [Required]
        public string Direction { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        public DateTime Admission { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
