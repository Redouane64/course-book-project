namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Groups.Entities;
    using MediatR;

    public class CreateGroupRequest : IRequest<Guid>
    {
        public CreateGroupRequest(string name, Guid directionId)
        {
            Name = name;
            DirectionId = directionId;
        }

        public Guid DirectionId { get; }
        public string Name { get; }
    }

    public class CreateGroupRequestHanlder : IRequestHandler<CreateGroupRequest, Guid>
    {
        private readonly DataContext context;

        public CreateGroupRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Handle(CreateGroupRequest request, CancellationToken cancellationToken)
        {
            var group = new GroupEntity
            {
                DirectionId = request.DirectionId,
                Name = request.Name
            };

            this.context.Groups.Add(group);

            await this.context.SaveChangesAsync(cancellationToken);

            return group.Id;
        }
    }
}
