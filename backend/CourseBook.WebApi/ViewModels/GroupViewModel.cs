namespace CourseBook.WebApi.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
