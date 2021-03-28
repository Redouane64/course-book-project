namespace CourseBook.WebApi.Directions.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Directions.ViewModels;
    using CourseBook.WebApi.Faculties.Repositories;

    using MediatR;

    public class GetDirectionsRequest : IRequest<IEnumerable<DirectionViewModel>>
    {
        public GetDirectionsRequest(Guid facultyId)
        {
            FacultyId = facultyId;
        }

        public Guid FacultyId { get; }
    }

    public class GetDirectionsRequestHanlder : IRequestHandler<GetDirectionsRequest, IEnumerable<DirectionViewModel>>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetDirectionsRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DirectionViewModel>> Handle(GetDirectionsRequest request, CancellationToken cancellationToken)
        {
            var directions = await repository.GetDirections(request.FacultyId, cancellationToken);
            return mapper.Map<IEnumerable<DirectionViewModel>>(directions);
        }
    }
}
