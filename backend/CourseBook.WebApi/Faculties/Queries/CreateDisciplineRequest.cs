namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Disciplines.Entities;
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
        private readonly DataContext context;

        public CreateDisciplineRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Guid> Handle(CreateDisciplineRequest request, CancellationToken cancellationToken)
        {
            var entity = new DisciplineEntity {
                Name = request.CreateDiscipline.Name,
                Literatures = request.CreateDiscipline.Literatures
            };

            context.Add(entity);

            await context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
