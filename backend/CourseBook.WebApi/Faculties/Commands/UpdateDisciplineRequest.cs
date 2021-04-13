namespace CourseBook.WebApi.Faculties.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using MediatR;

    public class UpdateDisciplineRequest : IRequest
    {
        public UpdateDisciplineRequest(Guid disciplineId, string name)
        {
            DisciplineId = disciplineId;
            Name = name;
        }

        public Guid DisciplineId { get; }
        public string Name { get; }
        public string Literature { get; set; }
    }

    public class UpdateDisciplineRequestHandler : IRequestHandler<UpdateDisciplineRequest>
    {
        private readonly DataContext context;

        public UpdateDisciplineRequestHandler(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(UpdateDisciplineRequest request, CancellationToken cancellationToken)
        {
            var discipline = await context.Disciplines.FindAsync(request.DisciplineId);

            if (discipline is not null)
            {
                discipline.Name = request.Name;
                discipline.Literatures = request.Literature;
                await this.context.SaveChangesAsync();
            }

            return await Unit.Task;
        }

    }
}
