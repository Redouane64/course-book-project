namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class GetFacultiesRequest : IRequest<object>
    {

    }


    public class GetFacultiesRequestHanlder : IRequestHandler<GetFacultiesRequest, object>
    {
        public Task<object> Handle(GetFacultiesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
