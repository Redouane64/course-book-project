namespace CourseBook.WebApi.Disciplines.ViewModels
{

    using CourseBook.WebApi.Groups.ViewModels;

    public class TeacherDisciplineViewModel
    {
        public DisciplineViewModel Discipline { get; set; }
        public GroupViewModel Group { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
    }
}
