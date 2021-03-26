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

    public class GetTeacherDisciplinesRequest : IRequest<object>
    {
        public GetTeacherDisciplinesRequest(string teacherId)
        {
            TeacherId = teacherId;
        }
        public string TeacherId { get; }
    }

    public class GetTeacherDisciplinesRequestHandler : IRequestHandler<GetTeacherDisciplinesRequest, object>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetTeacherDisciplinesRequestHandler(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<object> Handle(GetTeacherDisciplinesRequest request, CancellationToken cancellationToken)
        {
            var teacherDisciplines = await repository.GetTeacherDisciplines(request.TeacherId, cancellationToken);
            return this.mapper.Map<object>(teacherDisciplines);
        }
    }
}
