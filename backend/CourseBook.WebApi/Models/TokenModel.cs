namespace CourseBook.WebApi.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TokenModel
    {

        [Required]
        public string RefreshToken { get; set; }
    }
}
