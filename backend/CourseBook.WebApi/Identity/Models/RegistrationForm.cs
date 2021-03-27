namespace CourseBook.WebApi.Identity.Models
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
        public AccountType AccountType { get; set; }

        public Education Education { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class Education
    {
        [Required]
        public Guid Group { get; set; }

        [Required]
        public int AdmissionYear { get; set; }
    }
}
