namespace CourseBook.WebApi.Admin.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Admin.Services;
    using MediatR;

    public class DeleteUserRequest : IRequest
    {
        public DeleteUserRequest(string id)
        {
            Id = id;
        }
        public string Id { get; }
    }

    public class DeleteUserRequestHanlder : IRequestHandler<DeleteUserRequest>
    {
        private readonly IAdminService adminService;

        public DeleteUserRequestHanlder(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        public async Task<Unit> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            await adminService.DeleteUser(request.Id, cancellationToken);
            return await Unit.Task;
        }
    }
}
