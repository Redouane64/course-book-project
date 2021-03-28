
namespace CourseBook.WebApi.ViewModels
{
    using System.Collections.Generic;

    using CourseBook.WebApi.Disciplines.ViewModels;

    public class TeacherDisciplinesViewModel
    {
        public TeacherDisciplinesViewModel(IEnumerable<TeacherDisciplineViewModel> disciplines)
        {
            Disciplines = disciplines;
        }

        public IEnumerable<TeacherDisciplineViewModel> Disciplines { get; }
    }
}
