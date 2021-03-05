namespace CourseBook.WebApi.Profiles.Entities
{
    using System;

    using CourseBook.WebApi.Common;

    using Microsoft.AspNetCore.Identity;

    public sealed class ProfileEntity : Entity, IAggregateRoot
    {
        // Intended for use in mapping.
        public IdentityUser User { get; set; }

        public string UserId { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDay { get; set; }

        public int AdmissionYear { get; set; }

        public string Faculty { get; set; }

        public string Direction { get; set; }

        public string Group { get; set; }
    }
}
