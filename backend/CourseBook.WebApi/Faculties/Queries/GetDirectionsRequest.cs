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

        public GetDirectionsRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<DirectionViewModel>> Handle(GetDirectionsRequest request, CancellationToken cancellationToken)
        {
            return repository.GetDirections(request.FacultyId, cancellationToken);
        }
    }
}
