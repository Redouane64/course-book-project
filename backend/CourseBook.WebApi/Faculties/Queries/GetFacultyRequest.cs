namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.ViewModels;
    using MediatR;

    public class GetFacultyRequest : IRequest<FacultyDetailsViewModel>
    {
        public GetFacultyRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }


    public class GetFacultyRequestHanlder : IRequestHandler<GetFacultyRequest, FacultyDetailsViewModel>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetFacultyRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<FacultyDetailsViewModel> Handle(GetFacultyRequest request, CancellationToken cancellationToken)
        {
            var faculty = await repository.GetFacultyAsync(request.Id, cancellationToken);
            return this.mapper.Map<FacultyDetailsViewModel>(faculty);
        }
    }
}
