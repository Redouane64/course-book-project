namespace CourseBook.WebApi.Groups.ViewModels
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Disciplines.ViewModels;

    public class GroupViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class GroupDetailsViewModel : GroupViewModel
    {
        public DirectionViewModel Direction { get; set; }
        public ICollection<DisciplineViewModel> Disciplines { get; set; }
    }
}
