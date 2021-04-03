namespace CourseBook.WebApi.Disciplines.ViewModels
{
    using System.Collections.Generic;

    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Groups.ViewModels;

    public class DisciplineDetailsViewModel : DisciplineViewModel
    {
        public ICollection<DirectionViewModel> Directions { get; set; }

        public ICollection<GroupViewModel> Groups { get; set; }

        public ICollection<UserViewModel> Teachers { get; set; }
    }
}
