namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;

    public class DeleteFacultyRequest : IRequest
    {
        public DeleteFacultyRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteFacultyRequestHanlder : IRequestHandler<DeleteFacultyRequest>
    {
        private readonly IFacultiesRepository repository;

        public DeleteFacultyRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteFacultyRequest request, CancellationToken cancellationToken)
        {
            await repository.DeleteFaculty(request.Id, cancellationToken);
            return await Unit.Task;
        }
    }
}
