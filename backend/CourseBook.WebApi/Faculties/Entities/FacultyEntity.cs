namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;
    using CourseBook.WebApi.Common;

    sealed public class FacultyEntity : IEntity<Guid>, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<DirectionEntity> Directions { get; set; }
    }
}
