namespace CourseBook.WebApi.Disciplines.Entities
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Common;
    using CourseBook.WebApi.Common.Entities;

    public sealed class DisciplineEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<DirectionDisciplineEntity> Directions { get; set; }
        public ICollection<GroupDisciplineEntity> Groups { get; set; }
        public string Literatures { get; set; }
    }
}
