namespace CourseBook.WebApi.Profiles.ViewModels
{
    using System;

    using Identity.Models;

    public class ProfileViewModel
    {
        public string Id { get; set; }

        public AccountType AccountType { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDay { get; set; }

        public int? AdmissionYear { get; set; }

        public string Faculty { get; set; }

        public string Direction { get; set; }

        public string Group { get; set; }

        public string Avatar { get; set; }
    }
}
