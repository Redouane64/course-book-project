namespace CourseBook.WebApi.Profiles.Entities
{
    using System;

    using CourseBook.WebApi.Groups.Entities;

    public class UserEntity : IdentityEntity
    {
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public int? AdmissionYear { get; set; }
        public Guid? GroupId { get; set; }
        public GroupEntity Group { get; set; }
    }
}
