namespace CourseBook.WebApi.Identity.Models
{
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountType
    {
        Student,
        Teacher,
        StudentTeacher
    }
}
