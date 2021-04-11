namespace CourseBook.WebApi.Faculties.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using MediatR;

    public class UpdateGroupRequest : IRequest
    {
        public UpdateGroupRequest(Guid groupId, string name)
        {
            GroupId = groupId;
            Name = name;
        }
        public Guid GroupId { get; }
        public string Name { get; }
    }

    public class UpdateGroupRequestHandler : IRequestHandler<UpdateGroupRequest>
    {
        private readonly DataContext context;

        public UpdateGroupRequestHandler(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateGroupRequest request, CancellationToken cancellationToken)
        {
            var group = await context.Groups.FindAsync(request.GroupId);

            group.Name = request.Name;

            await this.context.SaveChangesAsync();

            return await Unit.Task;
        }

    }
}
