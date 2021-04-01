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

    public class CreateFacultyRequest : IRequest
    {
        public CreateFacultyRequest(CreateFaculty createFaculty)
        {
            CreateFaculty = createFaculty;
        }
        public CreateFaculty CreateFaculty { get; }

    }

    public class CreateFacultyRequestHanlder : IRequestHandler<CreateFacultyRequest>
    {
        private readonly IFacultiesRepository repository;

        public CreateFacultyRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(CreateFacultyRequest request, CancellationToken cancellationToken)
        {
            await repository.CreateFaculty(request.CreateFaculty, cancellationToken);
            return await Unit.Task;
        }
    }
}
