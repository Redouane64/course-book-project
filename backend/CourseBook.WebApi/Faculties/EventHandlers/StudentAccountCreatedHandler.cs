namespace CourseBook.WebApi.Faculties.EventHandlers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.Events;

    using MediatR;

    public class StudentAccountCreatedHandler : INotificationHandler<StudentAccountCreated>
    {
        public Task Handle(StudentAccountCreated notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
