namespace CourseBook.WebApi.Faculties.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using MediatR;

    public class UpdateFacultyRequest : IRequest
    {
        public UpdateFacultyRequest(Guid facultyId, string name)
        {
            FacultyId = facultyId;
            Name = name;
        }
        public Guid FacultyId { get; }
        public string Name { get; }
    }

    public class UpdateFacultyRequestHandler : IRequestHandler<UpdateFacultyRequest>
    {
        private readonly DataContext context;

        public UpdateFacultyRequestHandler(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateFacultyRequest request, CancellationToken cancellationToken)
        {
            var faculty = await context.Faculties.FindAsync(request.FacultyId);

            faculty.Name = request.Name;

            await this.context.SaveChangesAsync();

            return await Unit.Task;
        }

    }
}
