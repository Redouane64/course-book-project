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

    public class GetDirectionRequest : IRequest<DirectionDetailsViewModel>
    {
        public GetDirectionRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class GetDirectionRequestHanlder : IRequestHandler<GetDirectionRequest, DirectionDetailsViewModel>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetDirectionRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<DirectionDetailsViewModel> Handle(GetDirectionRequest request, CancellationToken cancellationToken)
        {
            var direction = await repository.GetDirectionAsync(request.Id, cancellationToken);
            return this.mapper.Map<DirectionDetailsViewModel>(direction);
        }
    }
}
