namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
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
        private readonly IMapper mapper;

        public GetGroupsRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GroupViewModel>> Handle(GetGroupsRequest request, CancellationToken cancellationToken)
        {
            var myObject = await repository.GetGroups(request.DirectionId, cancellationToken);
            return this.mapper.Map<IEnumerable<GroupViewModel>>(myObject);
        }
    }
}
