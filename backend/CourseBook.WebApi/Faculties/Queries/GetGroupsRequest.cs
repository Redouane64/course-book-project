namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class GetGroupsRequest : IRequest<object>
    {

    }

    public class GetGroupsRequestHanlder : IRequestHandler<GetGroupsRequest, object>
    {
        public Task<object> Handle(GetGroupsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
