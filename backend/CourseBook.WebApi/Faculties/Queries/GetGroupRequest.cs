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
            var group = await repository.GetGroup(request.Id);
            return this.mapper.Map<GroupDetailsViewModel>(group);
        }
    }
}
