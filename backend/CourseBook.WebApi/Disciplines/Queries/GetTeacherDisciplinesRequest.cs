namespace CourseBook.WebApi.Faculties.Queries
{
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Common.ViewModels;
    using CourseBook.WebApi.Disciplines.Repositories;
    using CourseBook.WebApi.Disciplines.ViewModels;

    using MediatR;

    public class GetTeacherDisciplinesRequest : IRequest<ItemsCollection<TeacherDisciplineViewModel>>
    {
        public GetTeacherDisciplinesRequest(string teacherId)
        {
            TeacherId = teacherId;
        }

        public string TeacherId { get; }
    }

    public class GetTeacherDisciplinesRequestHandler : IRequestHandler<GetTeacherDisciplinesRequest, ItemsCollection<TeacherDisciplineViewModel>>
    {
        private readonly ITeachersRepository repository;
        public readonly IMapper mapper;

        public GetTeacherDisciplinesRequestHandler(ITeachersRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ItemsCollection<TeacherDisciplineViewModel>> Handle(GetTeacherDisciplinesRequest request, CancellationToken cancellationToken)
        {
            var entities = await repository.GetTeacherDisciplines(request.TeacherId, cancellationToken);
            var disciplines = this.mapper.Map<TeacherDisciplineViewModel[]>(entities);
            return new ItemsCollection<TeacherDisciplineViewModel>(disciplines);
        }
    }
}
