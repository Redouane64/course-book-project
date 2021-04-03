namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Faculties.Entities;
    using MediatR;

    public class CreateFacultyRequest : IRequest<Guid>
    {
        public CreateFacultyRequest(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public class CreateFacultyRequestHanlder : IRequestHandler<CreateFacultyRequest, Guid>
    {
        private readonly DataContext context;

        public CreateFacultyRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Handle(CreateFacultyRequest request, CancellationToken cancellationToken)
        {
            var faculty = new FacultyEntity
            {
                Name = request.Name
            };

            this.context.Faculties.Add(faculty);

            await this.context.SaveChangesAsync(cancellationToken);

            return faculty.Id;
        }
    }
}
