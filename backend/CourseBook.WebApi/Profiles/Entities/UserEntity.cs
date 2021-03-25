
namespace CourseBook.WebApi.Profiles.Entities
{
    using System;
    using CourseBook.WebApi.Faculties.Entities;
    using CourseBook.WebApi.Models;

    public class UserEntity : IdentityEntity
    {
        public AccountType AccountType { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public int AdmissionYear { get; set; }
        public Guid FacultyId { get; set; }
        public FacultyEntity Faculty { get; set; }
        public Guid DirectionId { get; set; }
        public DirectionEntity Direction { get; set; }
        public Guid GroupId { get; set; }
        public GroupEntity Group { get; set; }
    }
}
