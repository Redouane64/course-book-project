namespace CourseBook.WebApi.Disciplines.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using CourseBook.WebApi.Common.Entities;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Disciplines.Entities;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Profiles.Entities;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class GetStudentDisciplinesRequest : IRequest<StudentDisciplinesViewModel>
    {
        public GetStudentDisciplinesRequest(Guid groupId)
        {
            GroupId = groupId;
        }

        public Guid GroupId { get; }

        public class GetStudentDisciplinesRequestHandler : IRequestHandler<GetStudentDisciplinesRequest, StudentDisciplinesViewModel>
        {
            private readonly DataContext context;
            private readonly IMapper mapper;

            public GetStudentDisciplinesRequestHandler(DataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<StudentDisciplinesViewModel> Handle(GetStudentDisciplinesRequest request, CancellationToken cancellationToken)
            {

                var disciplines = await this.context.Set<GroupDisciplineEntity>()
                    .Where(e => e.GroupId == request.GroupId)
                    .Include(e => e.Discipline)
                    .ToArrayAsync(cancellationToken);

                var groupedDiscipline = disciplines
                    .GroupBy(e => e.Semester)
                    .Select(s => new
                    {
                        Semester = s.Key,
                        Disciplines = s.Select(s => s.Discipline)
                    })
                    .ToArray();

                IEnumerable<DisciplineEntity> spring = null;
                IEnumerable<DisciplineEntity> autumn = null;

                if (groupedDiscipline.Length > 0) {
                    spring = groupedDiscipline[0]?.Disciplines;
                    autumn = groupedDiscipline[1]?.Disciplines;
                }

                return new StudentDisciplinesViewModel() {
                    Spring = mapper.Map<DisciplineViewModel[]>(spring),
                    Autumn = mapper.Map<DisciplineViewModel[]>(autumn)
                };
            }
        }
    }
}
