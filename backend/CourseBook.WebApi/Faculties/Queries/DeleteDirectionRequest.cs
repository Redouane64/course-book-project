namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class DeleteDirectionRequest : IRequest
    {
        public DeleteDirectionRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteDirectionRequestHanlder : IRequestHandler<DeleteDirectionRequest>
    {
        private readonly DataContext context;

        public DeleteDirectionRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteDirectionRequest request, CancellationToken cancellationToken)
        {
            var direction = await this.context.Directions
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (direction is null) {
                return await Unit.Task;
            }

            this.context.Directions.Remove(direction);

            await this.context.SaveChangesAsync(cancellationToken);

            return await Unit.Task;
        }
    }
}
