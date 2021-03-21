namespace CourseBook.WebApi.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TokenModel
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}
