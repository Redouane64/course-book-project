namespace CourseBook.WebApi.Disciplines.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Faculties.Repositories;

    using MediatR;

    public class GetDisciplineRequest : IRequest<DisciplineDetailsViewModel>
    {
        public GetDisciplineRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class GetDisciplineRequestHanlder : IRequestHandler<GetDisciplineRequest, DisciplineDetailsViewModel>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetDisciplineRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<DisciplineDetailsViewModel> Handle(GetDisciplineRequest request, CancellationToken cancellationToken)
        {
            var discipline = await repository.GetDisciplineAsync(request.Id, cancellationToken);
            return mapper.Map<DisciplineDetailsViewModel>(discipline);
        }
    }
}
