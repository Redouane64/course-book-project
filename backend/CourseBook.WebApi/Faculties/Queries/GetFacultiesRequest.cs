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

    public class GetFacultiesRequest : IRequest<IEnumerable<FacultyViewModel>>
    {

    }


    public class GetFacultiesRequestHanlder : IRequestHandler<GetFacultiesRequest, IEnumerable<FacultyViewModel>>
    {
        private readonly IFacultiesRepository repository;
        public readonly IMapper mapper;

        public GetFacultiesRequestHanlder(IFacultiesRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FacultyViewModel>> Handle(GetFacultiesRequest request, CancellationToken cancellationToken)
        {
            var myObject = await repository.GetAllAsync(cancellationToken);
            return this.mapper.Map<IEnumerable<FacultyViewModel>>(myObject);
        }
    }
}
