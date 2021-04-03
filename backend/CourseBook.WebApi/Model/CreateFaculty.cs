namespace CourseBook.WebApi.Model
{
    using System.ComponentModel.DataAnnotations;

    public class CreateFaculty
    {
        [Required]
        public string Name { get; set; }
    }
}
