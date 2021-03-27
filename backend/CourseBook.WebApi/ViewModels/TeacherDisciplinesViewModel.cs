
namespace CourseBook.WebApi.ViewModels
{
    using System.Collections.Generic;

    public class TeacherDisciplinesViewModel
    {
        public TeacherDisciplinesViewModel(IEnumerable<DisciplineViewModel> disciplines)
        {
            Disciplines = disciplines;
        }

        public IEnumerable<DisciplineViewModel> Disciplines { get; }
    }
}
