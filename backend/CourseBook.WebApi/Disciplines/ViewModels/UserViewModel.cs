
namespace CourseBook.WebApi.Disciplines.ViewModels
{
    using CourseBook.WebApi.Identity.Models;
    public class UserViewModel
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string[] Roles { get; set; }

        public string Email { get; set; }

    }
}
