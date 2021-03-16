namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Faculties.Repositories;
    using CourseBook.WebApi.ViewModels;
    using MediatR;

    public class GetFacultiesRequest : IRequest<IEnumerable<FacultyViewModel>>
    {

    }


    public class GetFacultiesRequestHanlder : IRequestHandler<GetFacultiesRequest, IEnumerable<FacultyViewModel>>
    {
        private readonly IFacultiesRepository repository;

        public GetFacultiesRequestHanlder(IFacultiesRepository repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<FacultyViewModel>> Handle(GetFacultiesRequest request, CancellationToken cancellationToken)
        {
            return repository.GetAllAsync(cancellationToken);
        }
    }
}
