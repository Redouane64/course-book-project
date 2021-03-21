namespace CourseBook.WebApi.Models
{
    using System;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountType
    {
        Student,
        Teacher
    }
}
