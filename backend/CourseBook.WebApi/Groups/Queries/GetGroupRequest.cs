namespace CourseBook.WebApi.Groups.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Groups.ViewModels;

    using MediatR;

    public class GetGroupRequest : IRequest<GroupDetailsViewModel>
    {
        public GetGroupRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class GetGroupRequestHanlder : IRequestHandler<GetGroupRequest, GroupDetailsViewModel>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetGroupRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<GroupDetailsViewModel> Handle(GetGroupRequest request, CancellationToken cancellationToken)
        {
            var group = await repository.GetGroupAsync(request.Id, cancellationToken);
            return mapper.Map<GroupDetailsViewModel>(group);
        }
    }
}
