namespace CourseBook.WebApi.Disciplines.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Profiles.Entities;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class GetStudentDisciplinesRequest : IRequest<StudentDisciplinesViewModel>
    {
        public GetStudentDisciplinesRequest(string studentId)
        {
            StudentId = studentId;
        }

        public string StudentId { get; }

        public class GetStudentDisciplinesRequestHandler : IRequestHandler<GetStudentDisciplinesRequest, StudentDisciplinesViewModel>
        {
            private readonly DataContext context;

            public GetStudentDisciplinesRequestHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<StudentDisciplinesViewModel> Handle(GetStudentDisciplinesRequest request, CancellationToken cancellationToken)
            {
                var disciplines = await this.context.Set<UserEntity>()
                    .AsNoTracking()
                    .Where(e => e.Id == request.StudentId)
                    .Include(e => e.Group)
                    .ThenInclude(e => e.Disciplines)
                    .Select(e => e.Group)
                    .SelectMany(e => e.Disciplines)
                    .GroupBy(e => e.Semester)
                    .ToListAsync(cancellationToken);

                return new StudentDisciplinesViewModel();
            }
        }
    }
}
