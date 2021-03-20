namespace CourseBook.WebApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public sealed class UpdateProfile
    {

        public string FullName { get; set; }

        [RegularExpression("\\d{4}")]
        public int AdmissionYear { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}
