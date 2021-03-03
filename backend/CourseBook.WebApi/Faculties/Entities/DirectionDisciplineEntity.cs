﻿namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public sealed class DirectionDisciplineEntity
    {
        public Guid DirectionId { get; set; }
        public DirectionEntity Direction { get; set; }

        public Guid DisciplineId { get; set; }
        public DisciplineEntity Discipline { get; set; }

    }
}
