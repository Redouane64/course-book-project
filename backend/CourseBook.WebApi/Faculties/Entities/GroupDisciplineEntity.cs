namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public sealed class GroupDisciplineEntity
    {
        public Guid GroupId { get; set; }

        public GroupEntity Group { get; set; }

        public Guid DisciplineId { get; set; }

        public DisciplineEntity Discipline { get; set; }

        public int Year { get; set; }

        public int Semester { get; set; }
    }
}
