namespace CourseBook.WebApi.Profiles.Entities
{
    using System;

    using CourseBook.WebApi.Common;

    using Microsoft.AspNetCore.Identity;

    public sealed class ProfileEntity : Entity, IAggregateRoot
    {

        public ProfileEntity()
        { }

        public ProfileEntity(string userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        // Intended for use in mapping.
        public IdentityUser User { get; set; }

        public string UserId { get; }

        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public int AdmissionYear { get; set; }
    }
}
