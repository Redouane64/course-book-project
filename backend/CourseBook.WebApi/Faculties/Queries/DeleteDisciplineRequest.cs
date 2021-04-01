namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;

    public class DeleteDisciplineRequest : IRequest
    {
        public DeleteDisciplineRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteDisciplineRequestHanlder : IRequestHandler<DeleteDisciplineRequest>
    {
        private readonly IFacultiesRepository repository;

        public DeleteDisciplineRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task Handle(DeleteDisciplineRequest request, CancellationToken cancellationToken)
        {
            var result = await repository.DeleteDiscipline(request.Id, cancellationToken);
        }
    }
}
