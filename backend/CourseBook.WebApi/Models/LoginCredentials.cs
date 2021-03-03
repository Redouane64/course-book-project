namespace CourseBook.WebApi.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LoginCredentials
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
