namespace CourseBook.WebApi.Faculties.Entities
{
    public sealed class GroupDisciplineEntity
    {
        public GroupEntity Group { get; set; }

        public DisciplineEntity Discipline { get; set; }

        public int Year { get; set; }

        public int Semester { get; set; }
    }
}
