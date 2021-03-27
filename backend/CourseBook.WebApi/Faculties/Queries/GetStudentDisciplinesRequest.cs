namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;

    public class GetStudentDisciplinesRequest : IRequest<object>
    {
        public GetStudentDisciplinesRequest(string studentId)
        {
            StudentId = studentId;
        }
        public string StudentId { get; }
    }

    public class GetStudentDisciplinesRequestHandler : IRequestHandler<GetStudentDisciplinesRequest, object>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetStudentDisciplinesRequestHandler(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<object> Handle(GetStudentDisciplinesRequest request, CancellationToken cancellationToken)
        {
            var studentDisciplines = await repository.GetStudentDisciplines(request.StudentId, cancellationToken);
            return this.mapper.Map<object>(studentDisciplines);
        }
    }
}
