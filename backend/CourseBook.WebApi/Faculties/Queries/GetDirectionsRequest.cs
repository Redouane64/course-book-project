namespace CourseBook.WebApi.Faculties.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class GetDirectionsRequest : IRequest<object>
    {
        public GetDirectionsRequest(string facultyId)
        {
            FacultyId = facultyId;
        }

        public string FacultyId { get; }
    }

    public class GetDirectionsRequestHanlder : IRequestHandler<GetDirectionsRequest, object>
    {
        public Task<object> Handle(GetDirectionsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
