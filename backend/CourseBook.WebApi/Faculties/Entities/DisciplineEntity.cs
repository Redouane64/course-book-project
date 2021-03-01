namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;
    using CourseBook.WebApi.Common;

    internal sealed class DisciplineEntity : Entity
    {
        public string Name { get; set; }

        public ICollection<DirectionEntity> Directions { get; set; }

        public ICollection<GroupDisciplineEntity> Groups { get; set; }
    }
}
