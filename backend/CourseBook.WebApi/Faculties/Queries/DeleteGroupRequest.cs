namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;

    public class DeleteGroupRequest : IRequest
    {
        public DeleteGroupRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class DeleteGroupRequestHanlder : IRequestHandler<DeleteGroupRequest>
    {
        private readonly IFacultiesRepository repository;

        public DeleteGroupRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task Handle(DeleteGroupRequest request, CancellationToken cancellationToken)
        {
            var result = await repository.DeleteGroup(request.Id, cancellationToken);
        }
    }
}
