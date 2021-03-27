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

    public class GetTeacherDisciplinesRequest : IRequest<TeacherDisciplinesViewModel>
    {
        public GetTeacherDisciplinesRequest(string teacherId)
        {
            TeacherId = teacherId;
        }
        public string TeacherId { get; }
    }

    public class GetTeacherDisciplinesRequestHandler : IRequestHandler<GetTeacherDisciplinesRequest, TeacherDisciplinesViewModel>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetTeacherDisciplinesRequestHandler(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<TeacherDisciplinesViewModel> Handle(GetTeacherDisciplinesRequest request, CancellationToken cancellationToken)
        {
            var entities = await repository.GetTeacherDisciplines(request.TeacherId, cancellationToken);
            var disciplines = this.mapper.Map<IEnumerable<DisciplineViewModel>>(entities);
            return new TeacherDisciplinesViewModel(disciplines);
        }
    }
}
