namespace CourseBook.WebApi.Faculties.EventHandlers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using CourseBook.WebApi.Common.Events;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Profiles.Entities;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class StudentAccountCreatedHandler : INotificationHandler<StudentAccountCreated>
    {
        private readonly DataContext context;

        public StudentAccountCreatedHandler(DataContext context)
        {
            this.context = context;
        }
        public async Task Handle(StudentAccountCreated notification, CancellationToken cancellationToken)
        {
            var group = await this.context.Groups.FirstOrDefaultAsync(g => g.Id == notification.Group , cancellationToken);

            if(group is not null)
            {
                group.Students.Add(new UserEntity { Id = notification.Id });
            }
        }
    }
}
