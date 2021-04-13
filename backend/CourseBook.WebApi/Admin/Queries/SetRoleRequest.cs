namespace CourseBook.WebApi.Admin.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using CourseBook.WebApi.Admin.Models;
    using CourseBook.WebApi.Profiles.Entities;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class SetRoleRequest : IRequest
    {
        public SetRoleModel Arguments { get; set; }

        public SetRoleRequest(SetRoleModel arguments)
        {
            Arguments = arguments;
        }

        public class SetRoleRequestHandler : IRequestHandler<SetRoleRequest>
        {
            private readonly UserManager<UserEntity> userManager;

            public SetRoleRequestHandler(UserManager<UserEntity> userManager)
            {
                this.userManager = userManager;
            }

            public async Task<Unit> Handle(SetRoleRequest request, CancellationToken cancellationToken)
            {
                var user = await this.userManager.FindByIdAsync(request.Arguments.UserId);
                await this.userManager.AddToRolesAsync(user, request.Arguments.Roles);
                return await Unit.Task;
            }
        }
    }
}
