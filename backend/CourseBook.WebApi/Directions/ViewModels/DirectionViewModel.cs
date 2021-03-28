namespace CourseBook.WebApi.Directions.ViewModels
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Groups.ViewModels;

    public class DirectionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class DirectionDetailsViewModel : DirectionViewModel
    {
        public ICollection<DisciplineViewModel> Disciplines { get; set; }
        public ICollection<GroupViewModel> Groups { get; set; }
    }
}
