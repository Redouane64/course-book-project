namespace CourseBook.WebApi.Admin.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using CourseBook.WebApi.Admin.Services;
    using CourseBook.WebApi.Disciplines.ViewModels;
    using CourseBook.WebApi.Profiles.Entities;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class GetUsersRequest : IRequest<IEnumerable<UserViewModel>>
    { }


    public class GetUsersRequestHanlder : IRequestHandler<GetUsersRequest, IEnumerable<UserViewModel>>
    {
        private readonly IAdminService adminService;
        public readonly IMapper mapper;
        private readonly UserManager<UserEntity> userManager;

        public GetUsersRequestHanlder(IAdminService adminService, IMapper mapper, UserManager<UserEntity> userManager)
        {
            this.adminService = adminService;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<UserViewModel>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = await adminService.GetUsers(cancellationToken);
            var vms = this.mapper.Map<IEnumerable<UserViewModel>>(users);

            // HACK: fast solution
            foreach (var item in vms)
            {
                var roles = await this.userManager.GetRolesAsync(new UserEntity { Id = item.Id });
                item.Roles = roles.ToArray();
            }

            return vms;
        }
    }

}
