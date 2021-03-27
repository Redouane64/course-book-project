namespace CourseBook.WebApi.Identity.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TokenModel
    {

        [Required]
        public string RefreshToken { get; set; }
    }
}
