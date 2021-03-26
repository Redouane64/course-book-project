namespace CourseBook.WebApi.Disciplines.Queries
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Faculties.Repositories;

    using MediatR;

    public class GetDisciplinesRequest : IRequest<IEnumerable<DisciplineViewModel>>
    { }

    public class GetDisciplinesRequestHanlder : IRequestHandler<GetDisciplinesRequest, IEnumerable<DisciplineViewModel>>
    {
        private readonly IFacultiesRepository repository;
        private readonly IMapper mapper;

        public GetDisciplinesRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<DisciplineViewModel>> Handle(GetDisciplinesRequest request, CancellationToken cancellationToken)
        {
            var disciplines = await repository.GetDisciplines(cancellationToken);
            return mapper.Map<IEnumerable<DisciplineViewModel>>(disciplines);
        }
    }
}