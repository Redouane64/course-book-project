namespace CourseBook.WebApi.ViewModels
{
    using System;
    using System.Text.Json.Serialization;
    using CourseBook.WebApi.Models;
    using Identity.Models;

    public class ProfileViewModel
    {
        public string Id { get; set; }

        public AccountType AccountType { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }

        public int AdmissionYear { get; set; }

        public string Faculty { get; set; }

        public string Direction { get; set; }

        public string Group { get; set; }

        public string Avatar { get; set; }
    }
}
