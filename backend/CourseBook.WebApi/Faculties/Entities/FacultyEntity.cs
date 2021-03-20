namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;
    using CourseBook.WebApi.Common;

    sealed public class FacultyEntity : Entity, IAggregateRoot
    {
        public string Name { get; set; }

        public ICollection<DirectionEntity> Directions { get; set; }
    }
}
