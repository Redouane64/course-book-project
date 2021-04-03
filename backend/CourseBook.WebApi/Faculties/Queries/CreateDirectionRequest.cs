namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Directions.Entities;
    using MediatR;


    public class CreateDirectionRequest : IRequest<Guid>
    {
        public CreateDirectionRequest(string name, Guid facultyId)
        {
            Name = name;
            FacultyId = facultyId;
        }

        public Guid FacultyId { get; }
        public string Name { get; }
    }

    public class CreateDirectionRequestHanlder : IRequestHandler<CreateDirectionRequest, Guid>
    {
        private readonly DataContext context;

        public CreateDirectionRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Handle(CreateDirectionRequest request, CancellationToken cancellationToken)
        {
            var entity = new DirectionEntity() {
                FacultyId = request.FacultyId,
                Name = request.Name
            };

            this.context.Directions.Add(entity);

            await this.context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
