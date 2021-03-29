namespace CourseBook.WebApi.Faculties.ViewModels
{
    using System;

    using CourseBook.WebApi.Disciplines.ViewModels;

    public class StudentDisciplinesViewModel
    {
        public DisciplineViewModel[] Autumn { get; set; }
        public DisciplineViewModel[] Spring { get; set; }
    }
}
