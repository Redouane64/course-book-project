namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Model;
    using MediatR;

    public class CreateGroupRequest : IRequest<Guid>
    {
        public CreateGroupRequest(CreateGroup createGroup, Guid directionId)
        {
            CreateGroup = createGroup;
            DirectionId = directionId;

        }
        public CreateGroup CreateGroup { get; }

        public Guid DirectionId { get; }

    }

    public class CreateGroupRequestHanlder : IRequestHandler<CreateGroupRequest, Guid>
    {
        private readonly IFacultiesRepository repository;

        public CreateGroupRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Guid> Handle(CreateGroupRequest request, CancellationToken cancellationToken)
        {
            var entity = await repository.CreateGroup(request.CreateGroup, cancellationToken);
            return entity.Id;
        }
    }
}
