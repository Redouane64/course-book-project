namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class DeleteFacultyRequest : IRequest
    {
        public DeleteFacultyRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteFacultyRequestHanlder : IRequestHandler<DeleteFacultyRequest>
    {
        private readonly DataContext context;

        public DeleteFacultyRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteFacultyRequest request, CancellationToken cancellationToken)
        {
            var faculty = await this.context.Faculties
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (faculty is null) {
                return await Unit.Task;
            }

            this.context.Faculties.Remove(faculty);

            await this.context.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }
    }
}
