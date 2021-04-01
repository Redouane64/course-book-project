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


    public class CreateDisciplineRequest : IRequest
    {
        public CreateDisciplineRequest(CreateDiscipline createDiscipline)
        {
            CreateDiscipline = createDiscipline;
        }
        public CreateDiscipline CreateDiscipline { get; }

    }

    public class CreateDisciplineRequestHanlder : IRequestHandler<CreateDisciplineRequest>
    {
        private readonly IFacultiesRepository repository;

        public CreateDisciplineRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateDisciplineRequest request, CancellationToken cancellationToken)
        {
            await repository.CreateDiscipline(request.CreateDiscipline, cancellationToken);
            return await Unit.Task;
        }
    }
}
