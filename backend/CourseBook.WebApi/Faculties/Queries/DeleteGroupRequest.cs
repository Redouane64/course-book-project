namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class DeleteGroupRequest : IRequest
    {
        public DeleteGroupRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteGroupRequestHanlder : IRequestHandler<DeleteGroupRequest>
    {
        private readonly DataContext context;

        public DeleteGroupRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteGroupRequest request, CancellationToken cancellationToken)
        {
            var group = await this.context.Groups
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (group is null) {
                return await Unit.Task;
            }

            this.context.Groups.Remove(group);

            await this.context.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }
    }
}
