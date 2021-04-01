namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;


    public class DeleteDirectionRequest : IRequest
    {
        public DeleteDirectionRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteDirectionRequestHanlder : IRequestHandler<DeleteDirectionRequest>
    {
        private readonly IFacultiesRepository repository;

        public DeleteDirectionRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task Handle(DeleteDirectionRequest request, CancellationToken cancellationToken)
        {
            var result = await repository.DeleteDirection(request.Id, cancellationToken);
        }
    }
}
