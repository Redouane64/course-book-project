namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;
    using CourseBook.WebApi.Common;

    internal sealed class DirectionEntity : Entity
    {
        public string Name { get; set; }

        public ICollection<DisciplineEntity> Disciplines { get; set; }
    }
}
