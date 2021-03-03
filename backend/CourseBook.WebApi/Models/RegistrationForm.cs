namespace CourseBook.WebApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RegistrationForm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Account Type", Description = "Allowed values 'Teacher' or 'Student' or 'Both'.")]
        public string AccountType { get; set; }

        [Required]
        public string Faculty { get; set; }

        [Required]
        public string Direction { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        [Display(Name = "Admission Year")]
        public int AdmissionYear { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare(nameof(Password), ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
