namespace CourseBook.WebApi.Directions.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Faculties.Repositories;

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
            return mapper.Map<DirectionDetailsViewModel>(direction);
        }
    }
}
