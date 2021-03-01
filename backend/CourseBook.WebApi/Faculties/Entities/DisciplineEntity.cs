namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;
    using CourseBook.WebApi.Common;

    public sealed class DisciplineEntity : Entity
    {
        public string Name { get; set; }

        // public ICollection<DirectionDisciplineEntity> Directions { get; set; }

        // public ICollection<GroupDisciplineEntity> Groups { get; set; }

        public string Literatures { get; set; }
    }
}
