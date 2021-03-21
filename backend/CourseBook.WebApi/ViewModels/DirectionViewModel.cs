namespace CourseBook.WebApi.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DirectionViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class DirectionDetailsViewModel : DirectionViewModel
    {
        public ICollection<DisciplineViewModel> Disciplines { get; set; }
    }
}
