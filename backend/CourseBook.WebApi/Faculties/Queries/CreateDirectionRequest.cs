namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Model;
    using MediatR;


    public class CreateDirectionRequest : IRequest
    {
        public CreateDirectionRequest(CreateDirection createDirection, Guid facultyId)
        {
            CreateDirection = createDirection;
            FacultyId = facultyId;
        }
        public CreateDirection CreateDirection { get; }

        public Guid FacultyId { get; }

    }

    public class CreateDirectionRequestHanlder : IRequestHandler<CreateDirectionRequest>
    {
        private readonly IFacultiesRepository repository;

        public CreateDirectionRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateDirectionRequest request, CancellationToken cancellationToken)
        {
            await repository.CreateDirection(request.CreateDirection, cancellationToken);
            return await Unit.Task;
        }
    }
}
