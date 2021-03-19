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
            var myObject = await repository.GetDirections(request.FacultyId, cancellationToken);
            return this.mapper.Map<IEnumerable<DirectionViewModel>>(myObject);
        }
    }
}
