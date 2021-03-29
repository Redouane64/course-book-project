namespace CourseBook.WebApi.Faculties.Queries
{
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Faculties.ViewModels;

    using MediatR;

    public class GetStudentDisciplinesRequest : IRequest<StudentDisciplinesViewModel>
    {
        public GetStudentDisciplinesRequest(string studentId)
        {
            StudentId = studentId;
        }
        public string StudentId { get; }
    }

    public class GetStudentDisciplinesRequestHandler : IRequestHandler<GetStudentDisciplinesRequest, StudentDisciplinesViewModel>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetStudentDisciplinesRequestHandler(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<StudentDisciplinesViewModel> Handle(GetStudentDisciplinesRequest request, CancellationToken cancellationToken)
        {
            var studentDisciplines = await repository.GetStudentDisciplines(request.StudentId, cancellationToken);
            return this.mapper.Map<StudentDisciplinesViewModel>(studentDisciplines);
        }
    }
}
