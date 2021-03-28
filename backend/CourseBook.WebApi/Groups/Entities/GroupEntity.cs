namespace CourseBook.WebApi.Groups.Entities
{
    using System;
    using System.Collections.Generic;

    using CourseBook.WebApi.Common;
    using CourseBook.WebApi.Common.Entities;
    using CourseBook.WebApi.Directions.Entities;
    using CourseBook.WebApi.Profiles.Entities;

    public sealed class GroupEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DirectionId { get; set; }
        public DirectionEntity Direction { get; set; }
        public ICollection<GroupDisciplineEntity> Disciplines { get; set; }
        public ICollection<UserEntity> Students { get; set; }
    }
}
