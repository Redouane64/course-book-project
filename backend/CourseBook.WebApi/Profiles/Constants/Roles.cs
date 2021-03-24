using CourseBook.WebApi.Models;

namespace CourseBook.WebApi.Profiles.Constants
{
    public class Roles
    {
        public static readonly string StudentRoleName = nameof(AccountType.Student);
        public static readonly string TeacherRoleName = nameof(AccountType.Teacher);
        public static readonly string AdministratorRoleName = "Administrator";

    }
}
