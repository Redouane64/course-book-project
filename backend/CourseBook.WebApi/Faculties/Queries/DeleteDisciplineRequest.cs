namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Data;
    using CourseBook.WebApi.Faculties.Repositories;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

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
        private readonly DataContext context;

        public DeleteDisciplineRequestHanlder(DataContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteDisciplineRequest request, CancellationToken cancellationToken)
        {
            var discipline = await this.context.Disciplines.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if(discipline is not null)
            {
                this.context.Remove(discipline);
                await this.context.SaveChangesAsync(cancellationToken);
            }
            return await Unit.Task;
        }
    }
}
