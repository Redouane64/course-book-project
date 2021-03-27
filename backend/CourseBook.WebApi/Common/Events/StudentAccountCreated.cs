namespace CourseBook.WebApi.Common.Events
{
    using System;
    using MediatR;

    public class StudentAccountCreated : INotification
    {
        public StudentAccountCreated(string id, Guid group)
        {
            Id = id;
            Group = group;
        }

        public string Id { get; }
        public Guid Group { get; }
    }
}
