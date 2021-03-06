namespace CourseBook.WebApi.ViewModels
{
    using System;

    public class ProfileViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public int AdmissionYear { get; set; }

        public string Faculty { get; set; }

        public string Direction { get; set; }

        public string Group { get; set; }
    }
}
