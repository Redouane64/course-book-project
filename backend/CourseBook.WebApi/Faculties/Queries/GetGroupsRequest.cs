namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.ViewModels;
    using MediatR;

    public class GetGroupsRequest : IRequest<IEnumerable<GroupViewModel>>
    {
        public GetGroupsRequest(Guid directionId)
        {
            DirectionId = directionId;
        }

        public Guid DirectionId { get; }
    }

    public class GetGroupsRequestHanlder : IRequestHandler<GetGroupsRequest, IEnumerable<GroupViewModel>>
    {
        private readonly IFacultiesRepository repository;

        public GetGroupsRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<GroupViewModel>> Handle(GetGroupsRequest request, CancellationToken cancellationToken)
        {
            return repository.GetGroups(request.DirectionId, cancellationToken);
        }
    }
}
