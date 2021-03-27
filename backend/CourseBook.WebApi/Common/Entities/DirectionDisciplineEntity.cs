namespace CourseBook.WebApi.Common.Entities
{
    using System;

    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Disciplines.Entities;

    public sealed class DirectionDisciplineEntity
    {
        public Guid DirectionId { get; set; }
        public DirectionEntity Direction { get; set; }

        public Guid DisciplineId { get; set; }
        public DisciplineEntity Discipline { get; set; }

    }
}
