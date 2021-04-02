namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.Model;
    using MediatR;

    public class CreateFacultyRequest : IRequest<Guid>
    {
        public CreateFacultyRequest(CreateFaculty createFaculty)
        {
            CreateFaculty = createFaculty;
        }
        public CreateFaculty CreateFaculty { get; }

    }

    public class CreateFacultyRequestHanlder : IRequestHandler<CreateFacultyRequest, Guid>
    {
        private readonly IFacultiesRepository repository;

        public CreateFacultyRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Guid> Handle(CreateFacultyRequest request, CancellationToken cancellationToken)
        {
            var entity = await repository.CreateFaculty(request.CreateFaculty, cancellationToken);
            return entity.Id;
        }
    }
}
