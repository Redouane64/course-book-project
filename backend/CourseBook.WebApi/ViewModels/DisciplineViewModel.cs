namespace CourseBook.WebApi.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
