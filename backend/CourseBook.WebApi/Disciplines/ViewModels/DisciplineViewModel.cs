namespace CourseBook.WebApi.Disciplines.ViewModels
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Groups.ViewModels;

    public class DisciplineViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class DisciplineDetailsViewModel : DisciplineViewModel
    {
        public ICollection<DirectionViewModel> Directions { get; set; }

        public ICollection<GroupViewModel> Groups { get; set; }
    }
}
