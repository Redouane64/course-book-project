namespace CourseBook.WebApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public class RegistrationForm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Display(Name = "Account Type", Description = "Allowed values 'Teacher' or 'Student' or 'Both'.")]
        public AccountType AccountType { get; set; }

        public string Faculty { get; set; }

        public string Direction { get; set; }

        public string Group { get; set; }

        [Required]
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
