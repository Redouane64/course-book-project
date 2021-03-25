namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using CourseBook.WebApi.Profiles.Entities;

    public sealed class GroupDisciplineEntity
    {
        public Guid GroupId { get; set; }
        public GroupEntity Group { get; set; }
        public Guid DisciplineId { get; set; }
        public DisciplineEntity Discipline { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public string TeacherId { get; set; }
        public UserEntity Teacher { get; set; }
    }
}
