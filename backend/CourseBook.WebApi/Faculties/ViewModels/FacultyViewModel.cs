namespace CourseBook.WebApi.Faculties.ViewModels
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Directions.ViewModels;

    public class FacultyViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class FacultyDetailsViewModel : FacultyViewModel
    {
        public ICollection<DirectionViewModel> Directions { get; set; }
    }
}
