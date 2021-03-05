namespace CourseBook.WebApi.Models
{
    using System;

    [Flags]
    public enum AccountType : ushort
    {
        Student = 2,
        Teacher = 4,
        Both = Student & Teacher
    }
}
