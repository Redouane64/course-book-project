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


    public class CreateDisciplineRequest : IRequest<Guid>
    {
        public CreateDisciplineRequest(CreateDiscipline createDiscipline)
        {
            CreateDiscipline = createDiscipline;
        }
        public CreateDiscipline CreateDiscipline { get; }

    }

    public class CreateDisciplineRequestHanlder : IRequestHandler<CreateDisciplineRequest, Guid>
    {
        private readonly IFacultiesRepository repository;

        public CreateDisciplineRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Guid> Handle(CreateDisciplineRequest request, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}
