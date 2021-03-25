namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;
    using CourseBook.WebApi.Common;

    public sealed class DirectionEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<DirectionDisciplineEntity> Disciplines { get; set; }
        public ICollection<GroupEntity> Groups { get; set; }
        public Guid FacultyId { get; set; }
        public FacultyEntity Faculty { get; set; }
    }
}
