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

    public class GetDisciplinesRequest : IRequest<IEnumerable<DisciplineViewModel>>
    {
        public GetDisciplinesRequest(string directionId)
        {
            DirectionId = directionId;
        }

        public string DirectionId { get; }
    }

    public class GetDisciplinesRequestHanlder : IRequestHandler<GetDisciplinesRequest, IEnumerable<DisciplineViewModel>>
    {
        private readonly IFacultiesRepository repository;

        public GetDisciplinesRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }
        public Task<IEnumerable<DisciplineViewModel>> Handle(GetDisciplinesRequest request, CancellationToken cancellationToken)
        {
            return repository.GetDisciplines(cancellationToken);
        }
    }
}
