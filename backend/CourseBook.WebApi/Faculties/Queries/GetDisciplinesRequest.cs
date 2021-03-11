namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class GetDisciplinesRequest : IRequest<object>
    {
    }

    public class GetDisciplinesRequestHanlder : IRequestHandler<GetDisciplinesRequest, object>
    {
        public Task<object> Handle(GetDisciplinesRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
