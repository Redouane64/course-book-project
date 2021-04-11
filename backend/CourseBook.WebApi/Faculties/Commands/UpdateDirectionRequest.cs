namespace CourseBook.WebApi.Faculties.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using MediatR;


    public class UpdateDirectionRequest : IRequest
    {
        public UpdateDirectionRequest(Guid directionId, string name)
        {
            DirectionId = directionId;
            Name = name;
        }
        public Guid DirectionId { get; }
        public string Name { get; }
    }

    public class UpdateDirectionRequestHandler : IRequestHandler<UpdateDirectionRequest>
    {
        private readonly DataContext context;

        public UpdateDirectionRequestHandler(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateDirectionRequest request, CancellationToken cancellationToken)
        {
            var direction = await context.Directions.FindAsync(request.DirectionId);

            direction.Name = request.Name;

            await this.context.SaveChangesAsync();

            return await Unit.Task;
        }

    }
}
