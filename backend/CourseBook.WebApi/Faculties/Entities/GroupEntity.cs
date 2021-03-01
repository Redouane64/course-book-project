namespace CourseBook.WebApi.Faculties.Entities
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Common;

    internal sealed class GroupEntity : Entity
    {
        public string Name { get; set; }

        public DirectionEntity Direction { get; set; }

        public ICollection<GroupDisciplineEntity> Disciplines { get; set; }
    }
}
